
using System;

public class ReminderNote : Note
{
    private DateTime ReminderDate { get; set; }
    //public DateTime ReminderDate { get; protected set; }
    //public string ReminderText { get; protected set; }

    public ReminderNote(string title, DateTime creationDate, DateTime reminderDate, string reminderText)
        : base(title, creationDate)
    {
        ReminderDate = reminderDate;
        ReminderText = reminderText;
    }

    public string ReminderText { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"\nReminder Date: {ReminderDate}\nReminder Text: {ReminderText}";
    }
}
