using EAD_Ca3.HttpRepository;
using Microsoft.AspNetCore.Components;
using Shared;

namespace EAD_Ca3.Pages
{
    public partial class Login
    {
        private UserForAuthenticationDto _userForAuthentication = new UserForAuthenticationDto();

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public bool ShowAuthError { get; set; }
        public string Error { get; set; }

        public async Task ExecuteLogin()
        {

            try
            {
                ShowAuthError = false;

                var result = await AuthenticationService.Login(_userForAuthentication);

                if (!result.IsAuthSuccessful)
                {
                    Error = result.ErrorMessage;
                    ShowAuthError = true;
                    Console.WriteLine(result.ErrorMessage);
                }
                else
                {
                    Console.WriteLine(result);
                    NavigationManager.NavigateTo("/");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
