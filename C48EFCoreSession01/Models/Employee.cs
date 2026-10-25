using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48EFCoreSession01.Models
{
      [Table("EmployeesTable")]
    
    internal class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Column(name:"EmployeeName",TypeName ="varchar")]
        [MaxLength(50,ErrorMessage ="Name Can not Exceed 50 chars")]
        [MinLength(3,ErrorMessage ="Name Must Be At Least 3 chars")]
        public string? EmpName { get; set; }
        [Column(TypeName ="decimal(10,2)")]
       
         public  decimal Salary { get; set; }
        [Range(22,40)]
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        //[DataType(DataType.EmailAddress)]
       
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
       
        public string PhoneNumber { get; set; }
        [NotMapped]
        public string UserName => Email.Split('@')[0];
    }
}
