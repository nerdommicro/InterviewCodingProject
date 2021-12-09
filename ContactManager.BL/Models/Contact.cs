using System.ComponentModel.DataAnnotations;


namespace ContactManager.BL.Models

{
    public class Contact
    {
        
        [Key]
        //public int ContactID { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        
        

        


    }
}
