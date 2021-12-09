using System.ComponentModel.DataAnnotations;


namespace ContactManager.BL.Models
{
    public class EmailAddresses
    {
        [Key]
        public int EmailID { get; set; }

        public string EmailAddress { get; set; }

        public EmailTypeEnum EmailType { get; set; }     
       
     }


    public enum EmailTypeEnum
    {
        Personal,
        Business
    }
}
