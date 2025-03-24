using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor to initialize Student object
    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    // Method to display student details
    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Use a List to store Student objects
        List<Student> studentList = new List<Student>();

        // Prepopulate the list with some students
        studentList.Add(new Student(1, "Alice", 20));
        studentList.Add(new Student(2, "Bob", 22));
        studentList.Add(new Student(3, "Charlie", 21));

        while (true)
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Remove Student");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Add a new student
                    Console.Write("Enter student ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter student name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter student age: ");
                    int age = int.Parse(Console.ReadLine());

                    studentList.Add(new Student(id, name, age));
                    Console.WriteLine("Student added successfully.");
                    break;

                case 2:
                    // View all students
                    if (studentList.Count == 0)
                    {
                        Console.WriteLine("No students available.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Student List ---");
                        foreach (var student in studentList)
                        {
                            student.Display();
                        }
                    }
                    break;

                case 3:
                    // Remove a student by ID
                    Console.Write("Enter student ID to remove: ");
                    int removeId = int.Parse(Console.ReadLine());
                    Student studentToRemove = studentList.Find(student => student.Id == removeId);

                    if (studentToRemove != null)
                    {
                        studentList.Remove(studentToRemove);
                        Console.WriteLine("Student removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Student with ID " + removeId + " not found.");
                    }
                    break;

                case 4:
                    // Exit the program
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}
