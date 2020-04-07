using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop.Models
{
    public class UserAccount
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string password;
        private bool textNotifications;
        private bool marketingEmails;
        

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Please provide a first name")]
        [MinLength(1, ErrorMessage = "First Name must be at least 1 character long")]
        [MaxLength(20, ErrorMessage = "First Name can only be 20 characters long")]
        public string FirstName { get => firstName; set => firstName = value; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please provide a last name")]
        [MinLength(1, ErrorMessage = "Last name must be at least 1 character long")]
        [MaxLength(20, ErrorMessage = "Last name can only be 20 characters long")]
        public string LastName { get => lastName; set => lastName = value; }

        [DisplayName("E-Mail")]
        [EmailAddress(ErrorMessage = "Must provide e-mail for account verification")]
        [Required(ErrorMessage = "Must provide e-mail for account username and verification")]
        public string Email { get => email; set => email = value; }

        [DisplayName("Cell Phone Number")]
        [Phone(ErrorMessage = "Must be a valid phone number, to receive Text Notifications")]
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        [Required(ErrorMessage = "Password is required for account creation")]
        [PasswordPropertyText(true)]
        public string Password { get => password; set => password = value; }

        [DisplayName("Receive Text Notifications")]
        public bool TextNotifications { get => textNotifications; set => textNotifications = value; }

        [DisplayName("Receive Marketing E-mails")]
        public bool MarketingEmails { get => marketingEmails; set => marketingEmails = value; }
    }
}
