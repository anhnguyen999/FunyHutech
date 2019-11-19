using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Cong chua bong bong
/// </summary>
namespace Student
{
    class Program
    {
        static Student[] studentList;
        static void Main(string[] args)
        {
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            int numOfStudent = 0;
            do
            {
                Console.Write("Number of Student = ");
            } while (!int.TryParse(Console.ReadLine(), out numOfStudent));

            InputStudentList(numOfStudent);
            Console.WriteLine("Danh sach sinh vien:");
            OutputStudentList();
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }

        private static void OutputStudentList()
        {
            //lap tung phan tu cua danh sach va in thong tin 
            foreach (Student item in studentList)
            {
                Console.WriteLine("-----");
                Console.Write("ID: {0}\nFullName: {1}\nMark: {2}\nFaculty: {3}", item.StudentID, item.FullName, item.Mark, item.Faculty);
                Console.WriteLine("-----");
            }
        }

        private static void InputStudentList(int numOfStudent)
        {
            //tao mang danh sach sinh vien
            studentList = new Student[numOfStudent];
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.Write("ID = ");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.Write("FullName = ");
                student.FullName = Console.ReadLine();
                Console.Write("Mark = ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Faculty = ");
                student.Faculty = Console.ReadLine();
                Console.WriteLine("---End---");
                //tuong tu nhap cho cac thuoc tinh khac
                //dua doi tuong vao mang
                studentList[i] = student;
            }
        }
    }
}
