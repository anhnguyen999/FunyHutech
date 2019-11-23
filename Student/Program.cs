using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        /// <summary>
        /// Duong Thanh Toan
        /// Truong Thanh Tuyen
        /// Tran Thi Anh Thu
        /// </summary>
namespace Student
{
    class Program
    {
        /// <summary>
        /// bai tap:
        /// 1.Xuat ra danh sach tat ca sinh vien CNTT
        /// 2. viet ham xuat trong student
        /// 3. doi danh sach sinh vien tu mang qua Lít
        /// 4. Viet 1 person lam lop cha cho lop Student
        /// </summary>
        static List<Student> studentList;
        static void Main(string[] args)
        {
            Console.Write("Number of Student = ");
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
           
            int numOfStudent;
            do
            {
                Console.Write("Number of Student");
            } while (!int.TryParse(Console.ReadLine(), out numOfStudent));
            
            InputStudentList(numOfStudent);
            Console.Write("Danh sach sinh vien: ");
            OutputStudentList();
            //dung man hinh de xem ket qua
            Console.Write("Danh sach sinh vien CNTT: ");
            OutputStudentITList();
            Console.ReadKey();
        }

        private static void OutputStudentITList()
        {
            //danh sach SV IT hjjjj
            foreach (Student item in studentList)
            {
                if(string.Compare(item.Faculty,"IT",true)==0)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("ID: {0}\n FullName: {1}\n Mark: {2}\nFaculty: {3}", item.StudentID, item.FullName, item.Mark, item.Faculty);
                    Console.WriteLine("--------");
                }
            }
        }
        private static void OutputStudentList()
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (Student item in studentList)
            {
                Console.WriteLine("--------");
                Console.WriteLine("ID: {0}\n FullName: {1}\n Mark: {2}\nFaculty: {3}",item.StudentID,item.FullName,item.Mark,item.Faculty);
                Console.WriteLine("--------");

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
                //dua doi tuong vao mang
                studentList.Add( student );
            }
        }
        
    }
}
