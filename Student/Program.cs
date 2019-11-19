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
        static int numOfStudent = 0;
        static Student[] studentList;
        static void Main(string[] args)
        {
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            do
            {
                Console.Write("Input Number Of Student: ");
            } while (!int.TryParse(Console.ReadLine(), out numOfStudent));
            //do..while de k bi thoat 
            Console.WriteLine("\n=====INPUT STUDENT LIST=====");
            InputStudentList(numOfStudent);
            Console.WriteLine("\n=====SHOW THE LIST OF STUDENT=====");
            ShowStudentList(studentList);
            ShowFacultyCNTT();
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }

        private static void InputStudentList(int numOfStudent)
        {
            //tao mang danh sach sinh vien
            studentList = new Student[numOfStudent];
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.WriteLine("Student {0}:", i + 1);
                Console.Write("ID: ");
                student.StudentID = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                student.FullName = Console.ReadLine();
                Console.Write("Mark: ");
                student.Mark = float.Parse(Console.ReadLine());
                Console.Write("Faculty: ");
                student.Faculty = Console.ReadLine();
                Console.WriteLine("---End A Student---\n");
                //dua doi tuong vao mang
                studentList[i] = student;
            }
        }
        private static void ShowStudentList(Student[] studentList)
        {
            foreach (Student st in studentList)
            {
                Console.Write("ID: {0}\nName: {1}\nMark: {2}\nFaculty: {3}", st.StudentID, st.FullName, st.Mark, st.Faculty);
                Console.WriteLine();
            }
        }

        private static void ShowFacultyCNTT()
        {
            Student[] listKQ = new Student[numOfStudent];
            listKQ = studentList.Where(p => p.Faculty == "CNTT").ToArray();
            if (listKQ.Count() > 0)
            {
                Console.WriteLine("\n=====SHOW STUDENT LIST IN THE FACULTY 'CNTT'=====");
                ShowStudentList(listKQ);
            }
            else
            {
                Console.WriteLine("There are no students in the faculty CNTT!\n");
            }
        }
    }
}