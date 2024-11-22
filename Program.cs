using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {

            new Student(1, "An", 16),
            new Student(2, "Nam", 14),
            new Student(3, "Nhi", 18),
            new Student(4, "Anh", 17),
            new Student(5, "Dung", 19)
        };

        // a. In danh sách toàn bộ học sinh
        Console.WriteLine("Danh sach toan bo hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // b. Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18
        Console.WriteLine("\nHoc sinh co tuoi tu 15 den 18:");
        var ageFilter = students.Where(s => s.Age >= 15 && s.Age <= 18);
        foreach (var student in ageFilter)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // c. Tìm và in ra học sinh có tên bắt đầu bằng chữ "A"
        Console.WriteLine("\nHoc sinh co ten bat đau bang chu 'A':");
        var nameFilter = students.Where(s => s.Name.StartsWith("A"));
        foreach (var student in nameFilter)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        // d. Tính tổng tuổi của tất cả học sinh trong danh sách
        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        // e. Tìm và in ra học sinh có tuổi lớn nhất
        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
        Console.WriteLine($"Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        // f. Sắp xếp danh sách theo tuổi tăng dần và in ra
        Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
        var sortedList = students.OrderBy(s => s.Age);
        foreach (var student in sortedList)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}
