using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataCreation.Core.Model
{
   public class StudentDataModel
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Please Enter the First Name")]
        [Display(Name = "Fisrt Name")]
        public string StudentFirstName { get; set; }

        [Required(ErrorMessage = "Please Enter the Second Name")]
        [Display(Name = "Second Name")]
        public string StudentSecondName { get; set; }

        [Required(ErrorMessage = "Please Enter the Department")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Please Enter the Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please Enter the Gender")]
        [Display(Name = "JoiningDate")]
        public DateTime? JoiningDate { get; set; }
      
        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        public DateTime? Create_Time_Stamp { get; set; }

        [Display(Name = "Update Date")]
        [DataType(DataType.Date)]
        public DateTime? Update_Time_Stamp { get; set; }

        public bool? IS_Deleted { get; set; }

    }
}
