namespace July11_Task
{
    public class ScholarshipStudent : Student
    {
        public ScholarshipStudent(string id, string name, string department) 
            : base(id, name, department)
        {
        }

        public override string StudentType => "Scholarship";

        public override double CalculateFee()
        {
            return TotalCredits * 15.0;
        }
    }
}
