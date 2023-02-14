using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "*Account Number is required")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only!")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "*Beneficiary Name is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only!")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "*Bank Name is required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 characters only!")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "*SWIFT Code is required")]
        [MaxLength(111, ErrorMessage = "Maximum 11 characters only!")]
        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "*Account is required")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy  hh:mm tt}")]
        public DateTime Date { get; set; }
    }
}
