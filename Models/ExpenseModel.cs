namespace ExpenseTrackerAngularCSharp.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public string Date {  get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
