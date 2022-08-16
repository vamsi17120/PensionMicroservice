using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PensionMicroService.Models
{
    public class PensionModel
    {
        [Key]
        public int  id { get; set; }
        public int Aadhaarcard { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string? Pan { get; set; }

        public int Salaryearned { get; set; }
        public int Allowances { get; set; }
        [Required]
        public string? Pensiontype { get; set; }

        [ForeignKey("BankDetails")]
        public int BankDetailId { get; set; }
        public virtual BankDetails BankDetails { get; set; }

    }
}
