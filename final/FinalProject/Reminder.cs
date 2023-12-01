
public class Reminder : Note
{
    private DateTime ReminderDate { get; set; }

    public Reminder(string title, DateTime creationDate, DateTime reminderDate)
    {
        Title = title;
        CreationDate = creationDate;
        ReminderDate = reminderDate;
    }

    public override void DisplayContent()
    {
        base.DisplayContent();
        Console.WriteLine($"Reminder Date: {ReminderDate}");
    }
}
