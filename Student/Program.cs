using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Thanh vien nhom TPV
//Nguyen Thai Hung Vuong, Nguyen Hoang Phuc, Nguyen Hoang Tu
//Bai tap
//1. Hay xuat ra danh sach sinh vien cong nghe thong tin
//2. Viet ham xuat trong student
//3. Doi ds sinh vien tu mang sang list
//4.Viet mot lop person lam lop cha cho lop student, dua thuoc tinh fullname va khoa sang Person


namespace Student
{
    class Program
    {
        static int numOfStudent = 0;
        static List<Student> studentList;
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
            Console.WriteLine("\n=====Nhap Danh Sach=====");
            InputStudentList(numOfStudent);
            Console.WriteLine("\n=====Xuat Danh Sach=====");
            ShowStudentList(studentList);
            ShowFacultyCNTT();
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }

        private static void InputStudentList(int numOfStudent) //Cau 3
        {
            //tao mang danh sach sinh vien
            studentList = new List<Student>();
            Student student;
            for (int i = 0; i < numOfStudent; i++)
            {
                student = new Student();
                Console.WriteLine("Student {0}:", i + 1);
                student.Input();
                //dua doi tuong vao mang
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

        private static void ShowFacultyCNTT()
        {
            List<Student> listKQ = new List<Student>();
            listKQ = studentList.Where(p => p.Faculty == "CNTT").ToList();
            if (listKQ.Count() > 0)
            {
                Console.WriteLine("\n=====Xuat danh sach sinh vien khoa CNTT=====");
                ShowStudentList(listKQ);
            }
            else
            {
                Console.WriteLine("\nKhong co sinh vien khoa CNTT!\n");
            }
        }


    }
}