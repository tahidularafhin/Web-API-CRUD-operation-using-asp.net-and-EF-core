using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp.netCoreMVCCRUD.Models
{
    public class Employee
    {   [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName ="nvarchar(250)")]
        [DisplayName("Name")]
        [Required(ErrorMessage ="This field is required")]
        public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }

        [Column(TypeName = "varchar(100)")]
      
        public string Position { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Office Location")]

        public string officeLocation { get; set; }

    }
}
