import { MyABPPractiseTemplatePage } from './app.po';

describe('MyABPPractise App', function() {
  let page: MyABPPractiseTemplatePage;

  beforeEach(() => {
    page = new MyABPPractiseTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
