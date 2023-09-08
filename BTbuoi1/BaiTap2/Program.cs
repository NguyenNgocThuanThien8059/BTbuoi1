using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(" === MENU === ");
                Console.WriteLine(" 1.Them sinh vien ");
                Console.WriteLine(" 2.Hien thi danh sach sinh vien ");
                Console.WriteLine(" 3.Xuat SV theo khoa CNTT ");
                Console.WriteLine(" 4.Xuat SV co DTB lon hon 5 ");
                Console.WriteLine(" 5.Xuat danh sach SV tang dan theo DTB ");
                Console.WriteLine(" 6.Xuat danh sach SV co DTB lon hon 5 va thuoc khoa CNTT ");
                Console.WriteLine(" 0. Thoat ");
                Console.Write(" Chon chuc nang (0 - 6): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent(studentList);
                        break;
                    case "2":
                        DisplayStudentList(studentList);
                        break;
                    case "3":
                        DisplayStudentByFaculty(studentList, "CNTT");
                        break;
                    case "4":
                        DisplayStudentWithHighAverageScore(studentList, 5);
                        break;
                    case "5":
                        SortStudentByAverageScore(studentList);
                        break;
                    case "6":
                        DisplayStudentByFacultyAndScore(studentList, "CNTT", 5);
                        break;
                    case "8":
                        DisplayStudentListWithLoai(studentList);
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine(" Ket thuc chuong trinh. ");
                        break;
                    default:
                        Console.WriteLine(" Tuy chon khong hop le. Vui long chon lai. ");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void AddStudent(List<Student> studentList)
        {
            Console.WriteLine(" === Nhap thong tin SV: === ");
            Student student = new Student();
            student.Input();
            studentList.Add(student);
            Console.WriteLine(" Them sinh vien thanh cong! ");
        }
        static void DisplayStudentList(List<Student> studentList)
        {
            Console.WriteLine(" === Danh sach chi tiet thong tin SV === ");
            foreach (Student student in studentList)
            {
                student.Show();
            }
        }
        static void DisplayStudentByFaculty(List<Student> studentList, string faculty)
        {
            Console.WriteLine(" === Danh sach SV thuoc khoa {0} === ", faculty);
            var students = studentList.Where(s => s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }
        static void DisplayStudentWithHighAverageScore(List<Student> studentList, float minDTB)
        {
            Console.WriteLine(" === Danh sach SV co diem TB >= {0} === ", minDTB);
            var students = studentList.Where(s => s.AverageScore >= minDTB).ToList();
            DisplayStudentList(students);
        }
        static void SortStudentByAverageScore(List<Student> studentList)
        {
            Console.WriteLine(" === Danh sach SV duoc sap xep theo DTB tang dan === ");
            var sortedStudents = studentList.OrderBy(s => s.AverageScore).ToList();
            DisplayStudentList(sortedStudents);
        }
        static void DisplayStudentByFacultyAndScore(List<Student> studentList, string faculty, float minDTB)
        {
            Console.WriteLine(" === Danh sach SV co DTB >= {0} va thuoc khoa {1} === ", minDTB, faculty);
            var students = studentList.Where(s => s.AverageScore >= minDTB && s.Faculty.Equals(faculty, StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayStudentList(students);
        }
        static void DisplayStudentListWithLoai(List<Student> studentList)
        {
            Console.WriteLine(" === Danh sach chi tiet thong tin SV === ");
            foreach (Student student in studentList)
            {
                student.ShowLoai();
            }
        }
    }
}
