using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Nguyen Hong Quan, Luu Gia Huy, Tran Anh Quan
namespace Student
{
    class Program
    {
        static Student[] studentList;
        static void Main(string[] args)
        {
            Console.Write("Number of Student = ");
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            int numOfStudent = 0;
            do
            {
              Console.Write("Nhap so sinh vien: ");
                
            }while (!int.TryParse(Console.ReadLine(), out numOfStudent));
           
            InputStudentList(numOfStudent);
            Console.WriteLine("Danh sach sinh vien: ");
            OutputStudentList();
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }

        private static void OutputStudentList()
        {
                foreach (Student item in studentList)
                {
	    
                Console.WriteLine("------");
                Console.Write("ID: {0}\nFullName: {1}\nMark: {2}\nFaculty: {3}", item.StudentID,item.FullName,item.Mark,item.Faculty);
                
	            }
        }

        private static void outStudentTech ( string a){
            foreach (Student item in studentList) {
                if ( string.Compare (a,item.Faculty, true)==0)
                     Console.WriteLine("------");
                Console.Write("ID: {0}\nFullName: {1}\nMark: {2}\nFaculty: {3}", item.StudentID,item.FullName,item.Mark,item.Faculty);
                


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
                Console.WriteLine("---- End ---");
                //tuong tu nhap cho cac thuoc tinh khac
                //dua doi tuong vao mang
                studentList[i] = student;

            }
            string a;
            Console.WriteLine("Nhap :");
            Console.ReadLine();

        }
    }
}
