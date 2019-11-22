using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_so_2
{
    static int numOfArray = 0;
    static List<Array> ArrayList;
    public static override InputArrayList(List<Array> ArrayList)
        {
            //tao mang danh sach 
            ArrayList = new List<Array>();
            Array array;
            for (int i = 0; i < numOfArray; i++)
            {
                array = new Array();
                Console.WriteLine(" {0}:", i + 1);
                Array.Input_Student();
                //dua doi tuong vao mang
                InputArrayList.Add(Array);
            }
        }
        public static void ShowArrayList(List<Array> ArrayList)
        {
            foreach (Student st in ArrayList)
            {
                st.Show();
                Console.WriteLine();
            }
        }
    }
    private static void ShowMaxCNTT()
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
    class Program
    { 
        public static void Main(string[] args)
        {
            Array arrray;
            Array ar = new Array();
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            do
            {
                Console.Write("Input Number Of Array := \n");
            } while (!int.TryParse(Console.ReadLine(), out numOfArray));
            //do..while de k bi thoat 

        //ham Switch Case chon nhap thong tin cho 2 doi tuong 
            Console.WriteLine("\n===================M E N U=====================");
            Console.WriteLine("\n Ban muon nhap thong tin cho ai?");
            Console.WriteLine("\n Nhan [1] de Nhap thong tin cho Student.");
            Console.WriteLine("\n Nhan [2] de Xuat thong tin cho Student.");
            Console.WriteLine("\n=============================================");
            Console.WriteLine("\n Nhan [3] de Nhap thong tin cho Teacher.");
            Console.WriteLine("\n Nhan [4] de Xuat thong tin cho Teacher.");
            Console.WriteLine("\n=============================================");
            Console.WriteLine("\n Nhan [5] de Xuat danh sach sinh vien khoa CNTT co diem trung binh cao nhat.");
            Console.WriteLine("\n Nhan [6] de Xuat danh sach sinh vien khoa CNTT co diem trung binh <5.");
            Console.WriteLine("\n Nhan [7] de Tim kiem mot Ten bat ki.");
            string Person = Console.ReadLine();
        switch (Person)
        {
            //case Student
            case "[1] Input Student":
                Console.WriteLine("\n NHAP THONG TIN CHO CLASS STUDENT:");
                Array.InputArrayList();
                break;
            case "[2] Output Student":
                Console.WriteLine("\n==XUAT THONG TIN CLASS STUDENT==");
                ShowArrayList(ArrayList);
                break;
            case "[3] Input Teacher":
                Console.WriteLine("\n NHAP THONG TIN CHO CLASS TEACHER:");
                InputArrayPersonList(numOfArray);
                break;
            case "[4] Output Teacher":
                Console.WriteLine("\n==XUAT THONG TIN CLASS TEACHER==");
                ShowArrayList(ArrayList);
                break;
            case "[5] ==Student Average Max==":
                ShowFacultyCNTT();
                break;
            case "[5] ==Student Average < 5==":
                ShowFacultyCNTT();
                break;
            case "[5] ==Search Name==":
                ShowFacultyCNTT();
                break;
            default:
                break;
        }
            //dung man hinh de xem ket qua
            Console.ReadKey();
        }
    }


