import { Component, Injector } from '@angular/core';
import { finalize } from 'rxjs/operators';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { FormsModule } from '@angular/forms';
import {
  PagedListingComponentBase,
  PagedRequestDto
} from '@shared/paged-listing-component-base';
import {
  PersonServiceProxy,
  CreatePersonDto,
  PersonDto,
  PersonDtoPagedResultDto
} from '@shared/service-proxies/service-proxies';

class PagedPageRequestDto extends PagedRequestDto {
  keyword: string;
}

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent extends PagedListingComponentBase<PersonDto> {

  persons: PersonDto[] = [];
  createPerson : PersonDto = new PersonDto
  keyword = '';

  constructor(
    injector: Injector,
    private _personService: PersonServiceProxy,
    private _modalService: BsModalService
  ) {
    super(injector);
  }

  list(
    request: PagedPageRequestDto,
    pageNumber: number,
    finishedCallback: Function
  ): void {
    request.keyword = this.keyword;

    this._personService
      .getPersons()
      .pipe(
        finalize(() => {
          finishedCallback();
        })
      )
      .subscribe((result: PersonDtoPagedResultDto) => {
        this.persons = result.items;
        console.log(this.persons);
      });
  }

  delete(person: PersonDto): void {
    abp.message.confirm(
      this.l('RoleDeleteWarningMessage', 'person'),
      undefined,
      (result: boolean) => {
        if (result) {
          this._personService
            .delete(person.id)
            .pipe(
              finalize(() => {
                abp.notify.success(this.l('SuccessfullyDeleted'));
                this.refresh();
              })
            )
            .subscribe(() => {});
        }
      }
    );
  }

  create(): void {
    this._personService.create(this.createPerson)
    .pipe(
      finalize(() => {
        abp.notify.success(this.l('SuccessfullyCreated'));
      })
    )
    .subscribe(() => {
      location.reload();
    });
  }

  editPerson(person: PersonDto): void {
    if(person.editable === true)
      this._personService.update(person)
      .pipe(
        finalize(() => {
          abp.notify.success(this.l('SuccessfullyEdited'));
        })
      )
      .subscribe(() => {});
      
    person.editable = !person.editable;
  }

}
