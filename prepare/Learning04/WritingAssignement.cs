public class WritingAssignment : Assignment
{
    private string writingInfor;

    public WritingAssignment(string studentName, string topic, string writingInfor)
        : base(studentName,topic)
    {
        this.writingInfor = writingInfor;
    }

    public string GetWritingInfor()
    {
        return writingInfor;
    }

    public string GetStudentName()
    {
        
         return base.GetSummary().Split(" - ")[0];
    }
}
