using Abp.MultiTenancy;
using MyABPPractise.Authorization.Users;

namespace MyABPPractise.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
