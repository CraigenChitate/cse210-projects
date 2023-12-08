using System;

public class ReminderNote : Note
{
    private DateTime _reminderDate { get; set; }
    public string ReminderText { get; set; }

    public ReminderNote(string title, DateTime creationDate, DateTime reminderDate, string reminderText)
        : base(title, creationDate)
    {
        _reminderDate = reminderDate;
        ReminderText = reminderText;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nReminder Date: {_reminderDate}\nReminder Text: {ReminderText}";
    }
}
