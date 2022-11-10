using ItemRazorV1.Base;
using ItemRazorV1.Service.Repositories.Model;

namespace ItemRazorV1.Pages.Customer
{
    public class EditCustomerModel : EditPageModelBase<Models.Customer, ICustomerRepository>
    {
        public EditCustomerModel(ICustomerRepository repository) 
            : base(repository, "GetAllCustomers")
        {
        }
    }
}
