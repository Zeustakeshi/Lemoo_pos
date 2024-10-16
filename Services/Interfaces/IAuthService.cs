using Lemoo_pos.Models;

namespace Lemoo_pos.Services.Interfaces
{
    public interface IAuthService
    {
        void CreateAccount(CreateStoreModel createAccountModel);
    }
}
