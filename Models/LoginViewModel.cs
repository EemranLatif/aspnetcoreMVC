namespace aspnetcoreMVC.Models
{
    public class LoginViewModel
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumberConfirmed { get; set;} = string.Empty;
        public string EmailConfirmed { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;

        public bool RememberMe {  get; set; }


    }
}
