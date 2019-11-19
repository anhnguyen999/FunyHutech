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
        static List<Student> studentList;
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
            OutputStudent(studentList);

            OutputStudentCNTT();
            
            //dung man hinh de xem ket qua
            Console.ReadKey();
            
            
        }

        private static void OutputStudentCNTT()
        {
            List<Student> studentKQ = new List<Student>();
            studentKQ = studentList.Where(p => p.Faculty == "CNTT").ToList();
            if(studentKQ.Count() > 0)
            {
                Console.WriteLine("Danh sach sinh vsien khoa CNTT");
                OutputStudent(studentKQ);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien khoa CNTT");
            }
        }

        private static void OutputStudent(List<Student> studentList)
        {
            foreach (Student item in studentList)
            {

                item.Show();
                
                Console.WriteLine("....");
            }
            
        }

        private static List<Student> InputStudentList(int numOfStudent)
        {
            //tao mang danh sach sinh vien
            studentList = new List<Student>();
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                Student item = new Student();
                item.Input();
                studentList.Add(item);
            }
            return studentList;
        }
    }
}
