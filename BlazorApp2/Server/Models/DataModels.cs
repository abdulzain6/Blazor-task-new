namespace BlazorApp2.Server.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation property for the many-to-many relationship
        public List<StudentCourse> StudentCourses { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int TeacherID { get; set; }

        // Navigation properties
        public Teacher Teacher { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }

    public class StudentCourse
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public int marks { get; set; }
    }

    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        public ICollection<Course> Courses { get; set; }
    }

}
