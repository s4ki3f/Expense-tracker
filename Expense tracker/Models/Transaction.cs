using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        //CatID
        public int CatagoryID { get; set; }
        public Catagory Catagory { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "navchar(75)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

    }
}
