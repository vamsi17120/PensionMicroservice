using System.ComponentModel.DataAnnotations;

namespace PensionMicroService.Models
{
    public class BankDetails
    {
        [Key]
        public int BankDetailId { get; set; }
        public string BankName { get; set; }
        public double AccountNumber { get; set; }
        public string BankType { get; set; }
    }
}
