namespace July11_Task
{
    public class RegularStudent : Student
    {
        public RegularStudent(string id, string name, string department) 
            : base(id, name, department)
        {
        }

        public override string StudentType => "Regular";

        public override double CalculateFee()
        {
            return TotalCredits * 100.0;
        }
    }
}
