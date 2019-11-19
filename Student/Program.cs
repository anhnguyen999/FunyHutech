using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Thanh vien nhom TPV
//Nguyen Thai Hung Vuong, Nguyen Hoang Phuc, Nguyen Hoang Tu
//Bai tap
//Hay xuat ra danh sach sinh vien cong nghe thong tin
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
            Console.WriteLine("\n Danh sach sinh vien");
            OutputStudentList();
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }

        private static void OutputStudentList(List<Student>)
        {
            foreach (Student item in studentList)
            {
                Console.WriteLine("-----------");
                Console.WriteLine("\nID: {0}\n FullName:{1}\n Mark: {2}\n Faculty: {3}", item.StudentID, item.FullName, item.Mark,item.Faculty);
            }
        }
        private static List<Student> LayListSinhVienTest()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student(1, "Nguyen Hoang Phuc", 9, "CNTT"));
            listStudent.Add(new Student(2, "Nguyen Hoang Tu", 9, "QTKD"));
            listStudent.Add(new Student(3, "Nguyen Hoang Nam", 9, "CNTT"));
            return listStudent;
        }
        private static void InputStudentList(int numOfStudent)
        {
            //tao mang danh sach sinh vien
           /* studentList = new Student[numOfStudent];
           Student student;
           for (int i = 0; i < numOfStudent; i++)
           {
              student = new Student();
               Console.Write("\nID = ");
               student.StudentID = int.Parse(Console.ReadLine());
               Console.Write("\nFullName = ");
               student.FullName = Console.ReadLine();
               Console.Write("\nMark = ");
               student.Mark = float.Parse(Console.ReadLine());
               Console.Write("\nFaculty = ");
               student.Faculty = Console.ReadLine();
               Console.Write("\n---End---");
               //tuong tu nhap cho cac thuoc tinh khac
               //dua doi tuong vao mang
               studentList[i] = student;
               */
            List<Student> listStudent = LayListSinhVienTest();
              OutputStudentList(listStudent);
               
                List<Student> listSV = listStudent.Where(p => p.Faculty == "CNTT").ToList();
                if(listSV.Count >0)
                {
                    Console.WriteLine("--Danh sach sinh vien khoa CNTT");
                    OutputStudentList(listStudent);
                }
                else
                {
                    Console.WriteLine("--Khong tim thay sinh vien thuoc khoa CNTT")
                }
                Console.ReadKey();
            }
        }
    }
}


