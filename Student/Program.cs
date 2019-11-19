using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Nguyen Trong Duong
/// Do Thanh Son
/// Vu Tri Toan
/// </summary>
namespace Student
{
    class Program
    {
        static List<Student> studentList;
        static void Main(string[] args)
        {
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            int numOfStudent = 0;
            do
            {
                Console.Write("Nhap so sinh vien: ");
            } while (!int.TryParse(Console.ReadLine(), out numOfStudent));
            InputStudentList(numOfStudent);
            Console.WriteLine("Danh sach sinh vien");
            OutputStudentList();
            OutputFaculty();
            try
            {
                numOfStudent = int.Parse(Console.ReadLine());

            }
            catch (Exception ex)
            {

                Console.WriteLine("Invalid Input");
            }



            //dung man hinh de xem ket qua
            Console.ReadKey();


        }
        private static void OutputStudentList()
        {
            foreach (Student item in studentList)
            {
                Console.WriteLine("___");
                Console.Write("ID: {0}\n FullName: {1}\n Mark: {2}\n Faculty: {3}", item.StudentID, item.FullName, item.Mark, item.Faculty);
                Console.WriteLine("\n_____");
            }
        }
        private static void OutputFaculty()
        {

            string faculty;
            Console.Write("Nhap ten khoa : ");
            faculty = Console.ReadLine();
            foreach (Student item in studentList)
            {
                if (String.Compare(faculty, item.Faculty, true) == 0)
                {
                    Console.WriteLine("___");
                    Console.Write("ID: {0}\n FullName: {1}\n Mark: {2}\n Faculty: {3}", item.StudentID, item.FullName, item.Mark, item.Faculty);
                    Console.WriteLine("\n_____");
                }

            }
        }
        private static void InputStudentList(int numOfStudent)
        {
            //tao mang danh sach sinh vien
            studentList = new List<Student>();
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                student.Input();
                //tuong tu nhap cho cac thuoc tinh khac
                //dua doi tuong vao mang
                studentList.Add(student);
            }

        }
    }
}