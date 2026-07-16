namespace July11_Task
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }

        public Course(string courseId, string courseName, int credits)
        {
            CourseId = courseId;
            CourseName = courseName;
            Credits = credits;
        }
    }
}
