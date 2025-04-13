using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class KuliahMahasiswa2311104053
{
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_2_2311104053.json");
        CourseList data = JsonSerializer.Deserialize<CourseList>(json);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var course in data.courses)
        {
            Console.WriteLine($"MK {i} {course.code} - {course.name}");
            i++;
        }
    }
    
}
