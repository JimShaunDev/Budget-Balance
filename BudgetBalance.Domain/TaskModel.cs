namespace BudgetBalance.Domain
{
    public class TaskModel
    { 
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string DueDate { get; set; } = null!;
        public bool Reminder { get; set; }
    }

}