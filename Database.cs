namespace Student_Form
{
    internal class Database
    {
        private struct Student
        {
            public string UUID;
            public string firstName;
            public string lastName;
            public string courseName;
            public int courseId;
            public int progress;

            public Student(string uuid, string firstName, string lastName, string courseName, int courseId, int progress)
            {
                UUID = uuid;
                this.firstName = firstName;
                this.lastName = lastName;
                this.courseName = courseName;
                this.courseId = courseId;
                this.progress = progress;
            }
        }

        private Student[] students;

        public Database()
        {
            students = new Student[]
            {
                new Student("1a2b3c", "John", "Doe", "Computer Science", 101, 80),
                new Student("4d5e6f", "Jane", "Smith", "Mathematics", 102, 90),
                new Student("7g8h9i", "Alice", "Brown", "Physics", 103, 75),
                new Student("0j1k2l", "Bob", "Johnson", "Biology", 104, 85)
            };
        }

        // Method to get a student by first name
        public Student? Get(string firstName)
        {
            foreach (var student in students)
            {
                if (student.firstName == firstName)
                {
                    return student;
                }
            }
            return null; // Return null if no student is found
        }
    }
}
