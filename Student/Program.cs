using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Phan Hai Dang, Do Van Linh, Truong Huu Uy   
/// </summary>

namespace Student
{
    class Program
    {
        static Student[] studentList;
        static int numOfStudent;
        static void Main(string[] args)
        {
           
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            numOfStudent = 0;
            do
            {
                Console.Write("Number of Student = ");
            } while(!int.TryParse(Console.ReadLine(), out numOfStudent));


            Console.WriteLine("++++++++++++++++++Nhap Vao Danh Sach SV +++++++++++++++++");
            InputStudentList(numOfStudent);
            Console.WriteLine("++++++++++++++++++Danh Sach Sinh Vien+++++++++++++++++");
            OutputStudent();

            OutputStudentCNTT();
            //dung man hinh de xem ket qua
            Console.ReadKey();
            
            
        }

        private static void OutputStudentCNTT()
        {
            Student[] studentKQ = new Student[numOfStudent];
            studentKQ = studentList.Where< p => p.where
        }

        private static void OutputStudent()
        {
            foreach (Student item in studentList)
            {
                
                Console.Write("ID: {0}\nFullName: {1}\nMark: {2}\nFaculty: {3}\n", item.StudentID, item.FullName,item.Mark,item.Faculty);
                Console.WriteLine("...");
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
                Console.WriteLine("+++ Student {0} +++", i + 1);
                Console.Write("ID = ");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.Write("Full Name = ");
                student.FullName = Console.ReadLine();
                Console.Write("Mark = ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Faculty = ");
                student.Faculty = Console.ReadLine();
                //tuong tu nhap cho cac thuoc tinh khac
                //dua doi tuong vao mang
                studentList[i] = student;
            }
        }
    }
}
