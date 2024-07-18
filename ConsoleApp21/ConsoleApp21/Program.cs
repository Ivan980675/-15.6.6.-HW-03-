class program { 
public static List<Student> GetAllStudents(List<Classroom> classrooms)
{
    return classrooms.SelectMany(c => c.Students).ToList();
}

public class Student
{
    public string Name { get; set; }
}

public class Classroom
{
    public string Name { get; set; }
    public List<Student> Students { get; set; }
}


var classrooms = new List<Classroom>
{
new Classroom
{
Name = "Class A",
Students = new List<Student>
{
new Student { Name = "John" },
new Student { Name = "Jane" },
new Student { Name = "Bob" }
}
},
new Classroom
{
Name = "Class B",
Students = new List<Student>
{
new Student { Name = "Alice" },
new Student { Name = "Tom" },
new Student { Name = "Sarah" }
}
}
};


}