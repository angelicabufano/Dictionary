namespace Dictionary;

internal class Program {
    static void Main(string[] args) {

        List<Student> students = new List<Student>();   
        students.Add(new Student { Id = 1, Name = "Angelica" });
        students.Add(new Student { Id = 2, Name = "Emma" });
        students.Add(new Student { Id = 3, Name = "Lauren" });


        Dictionary<int, Student> StudentDictionary = new Dictionary<int, Student>();
        foreach (var student in students) {
            StudentDictionary.Add(student.Id, student);
        }

        var Angelica = StudentDictionary[1];
        Console.WriteLine($"Id: {Angelica.Id}, Name: {Angelica.Name}");
    }
}

internal class Student {
    public int Id { get; set; }
    public string Name { get; set; }

}