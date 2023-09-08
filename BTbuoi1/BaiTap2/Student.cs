using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    class Student
    {
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;
        private string loai;
        public String StudentID
        {
            get => studentID;
            set => studentID = value;
        }
        public String FullName
        {
            get => fullName;
            set => fullName = value;
        }
        public float AverageScore
        {
            get => averageScore;
            set => averageScore = value;
        }
        public String Faculty
        {
            get => faculty;
            set => faculty = value;
        }
        public String Loai
        {
            get => loai;
            set => loai = value;
        }
        public Student()
        {
        }
        public Student(string studentID, string fullName, float averageScore, string faculty,string loai)
        {
            this.studentID = studentID;
            this.fullName = fullName;
            this.averageScore = averageScore;
            this.faculty = faculty;
            this.loai = loai;
        }
        public void Input()
        {
            Console.WriteLine(" Nhap MSSV: ");
            studentID = Console.ReadLine();
            Console.WriteLine(" Nhap Ho Ten SV: ");
            fullName = Console.ReadLine();
            Console.WriteLine(" Nhap DiemTB: ");
            averageScore = float.Parse(Console.ReadLine());
            Console.WriteLine(" Nhap Khoa: ");
            faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine(" MSSV: {0} | HoTen: {1} | Khoa: {2} | DiemTB: {3}", studentID, fullName, faculty, averageScore);
        }
        public void ShowLoai()
        {
            if(averageScore >= 9 && averageScore <= 10)
            {
                Loai = "Xuat Sac";
            }
            if (averageScore >= 8 && averageScore < 9)
            {
                Loai = " Gioi";
            }
            if (averageScore >= 7 && averageScore < 8)
            {
                Loai = "Kha";
            }
            if (averageScore >= 5 && averageScore < 7)
            {
                Loai = "Trung Binh";
            }
            if (averageScore >= 4 && averageScore < 5)
            {
                Loai = "Yeu";
            }
            if (averageScore < 4)
            {
                Loai = "Kem";
            }
            Console.WriteLine(" MSSV: {0} | HoTen: {1} | Khoa: {2} | DiemTB: {3} | Xep loai: {4} ", studentID, fullName, faculty, averageScore, loai);
        }
    }
}
