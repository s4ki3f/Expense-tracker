using System.ComponentModel.DataAnnotations;

namespace Expense_tracker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }


    }
}
