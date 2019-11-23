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
        /// 3. doi danh sach sinh vien tu mang qua List
        /// 4. Viet 1 person lam lop cha cho lop Student
        /// </summary>
        static List<Student> studentList;
        static void Main(string[] args)
        {
            
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
            OutputStudentList(studentList);
            //dung man hinh de xem ket qua
            Console.WriteLine("Danh sach sinh vien CNTT: ");    
            Console.WriteLine("Nhap khoa can xuat danh sach sinh vien: ");
            string faculty = Console.ReadLine();
            List <Student> studentSearchResult = SearchFucalty(faculty);
            Console.WriteLine("Danh sach sinh vien thuoc khoa {0} ",faculty);
            OutputStudentList(studentSearchResult);
            Console.ReadKey();
        }
        private static List<Student> SearchFucalty(string faculty)
        {
            return studentList.Where(s => s.Faculty.ToLower() == faculty.ToLower()).ToList();
        }
        private static void OutputStudentList(List<Student> studentList)
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

                studentList.Add(student);
            }
        }
        
    }
}
