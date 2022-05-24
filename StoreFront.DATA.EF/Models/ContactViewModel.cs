using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StoreFront.DATA.EF.Models
{
    public class ContactViewModel
    {

        //We can use Data Annotations to add validation to our model.  This is useful when we have required fields or need certain types of information.

        [Required(ErrorMessage = "*Name is required")] // Makes the field required
        public string Name { get; set; }
        
        [DataType(DataType.PhoneNumber)] 
        public string Phone { get; set; }
        [Required(ErrorMessage = "*Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "*Subject required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "*Message is required")]
        [DataType(DataType.MultilineText)]//Makes the textbox for this field bigger
        public string Message { get; set; }


    }
}
