using Microsoft.AspNetCore.Identity;

namespace AceJobAgency.Model
{
	public class ApplicationUser : IdentityUser
	{


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string NRIC { get; set; }
        public string DOB { get; set; }
        public string Resume { get; set; }
        public string Whoami { get; set; }
    }
}
