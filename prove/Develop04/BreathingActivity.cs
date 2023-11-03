// Breathing Activity class
public class BreathingActivity : Activity
{
    public BreathingActivity() : base("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing") { }

    public override void Start()
    {
        base.Start();
        PerformBreathingActivity();
    }

    private void PerformBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }

        base.End();
    }
}
