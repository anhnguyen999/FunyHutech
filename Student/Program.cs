using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// TRẦN SỸ TÀI, LÊ ĐỨC ANH, NGUYỄN ĐĂNG KHÔI
/// 1. Xuất danh sách sinh viên thuộc khoa CNTT
/// 2. Viết hàm xuất trong class Student
/// 3. Đổi danh sách sinh viên từ Array sang List
/// 4. Viết 1 class Person làm lớp cha cho class Student (Đưa thuộc tính FullName và Faculty sang class Person)
/// </summary>

namespace Student
{
    class Program
    {
        public static int numOfStudent;
        public static List<Student> studentList = new List<Student>();
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
  
            Console.WriteLine("\n=====INPUT THE LIST OF STUDENT=====");
            InputStudentList(numOfStudent);
            Console.WriteLine("\n=====SHOW THE LIST OF STUDENT=====");
            ShowStudentList(studentList);

            Console.WriteLine("Faculty: ");
            string faculty = Console.ReadLine();
            List<Student> studentShowFaculty = SearchFaculty(faculty);
            Console.WriteLine("The List of Student in the Faculty: {0}", faculty);
            ShowFacultyIT();

            //dừng màn hình để xem kết quả
            Console.ReadKey();
        }

        private static void InputStudentList(int numOfStudent)
        {
            //tạo mảng cho danh sách sinh viên 
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.WriteLine("Student {0}:", i + 1);
                student.Input();
                //đưa đối tượng vào array
                studentList.Add(student);
            }
        }
        private static void ShowStudentList(List<Student> studentList)
        {           
            foreach (Student st in studentList)
            {
                st.Show();
                Console.WriteLine();
            }
        }
       
        private static List<Student> SearchFaculty(string faculty)
        {
            return studentList.Where(p => p.Faculty.ToLower() == faculty.ToLower()).ToList();
        }

        private static void ShowFacultyIT()
        {
            foreach (Student st in studentList)
            {
                if (string.Compare(st.Faculty, "IT", true) == 0)
                {
                    Console.WriteLine("ID: {0}\nName: {1}\nMark: {2}\nFaculty: {3}", st.StudentID, st.FullName, st.Mark, st.Faculty);
                }
            }
        }

    }
}
