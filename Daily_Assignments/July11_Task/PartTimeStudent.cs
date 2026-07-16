namespace July11_Task
{
    public class PartTimeStudent : Student
    {
        public PartTimeStudent(string id, string name, string department) 
            : base(id, name, department)
        {
        }

        public override string StudentType => "Part-Time";

        public override double CalculateFee()
        {
            return TotalCredits * 150.0;
        }
    }
}
