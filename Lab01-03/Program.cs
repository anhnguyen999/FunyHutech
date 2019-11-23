using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class Program
    {
        static List<CustomerVN> customerVNList;  
        static List<ForeignCustomer> fCustomerList;
        static void Main(string[] args)
        {
            customerVNList = new List<CustomerVN>();
            fCustomerList = new List<ForeignCustomer>();
            int choose;
            do
            {
                Console.WriteLine("======================== MENU =======================");
                Console.WriteLine("==1. Enter the invoice list of customers           ==");
                Console.WriteLine("==2. Export the invoice list of customers          ==");
                Console.WriteLine("==3. Export invoices in September 2019             ==");
                Console.WriteLine("==4. Total kw consumed by Vietnamese customers     ==");
                Console.WriteLine("==5. Find the code and then export the total amount==");
                Console.WriteLine("==0. Exit                                          ==");
                Console.WriteLine("=====================================================");
                Console.Write("choose: ");
                choose = int.Parse(Console.ReadLine());
                // use switch... case...
                switch (choose)
                {
                    case 1:
                        int choose1;
                        do
                        {
                            Console.WriteLine("======================== MENU =======================");
                            Console.WriteLine("==1. Enter the invoice list of customers VN        ==");
                            Console.WriteLine("==2. Enter the invoice list of foreign customers   ==");
                            Console.WriteLine("==0. Exit                                          ==");
                            Console.WriteLine("=====================================================");
                            Console.WriteLine("choose: ");
                            choose1 = int.Parse(Console.ReadLine());
                            switch (choose1)
                            {
                                case 1:
                                    
                                    CustomerVN customerVN = new CustomerVN();
                                    customerVN.Input();
                                    //dua doi tuong vao mang
                                    customerVNList.Add(customerVN);
                                    break;
                                case 2:
                                    
                                    ForeignCustomer foreignCustomer;
                                    foreignCustomer = new ForeignCustomer();
                                    foreignCustomer.Input();
                                    //dua doi tuong vao mang
                                    fCustomerList.Add(foreignCustomer);
                                    break;
                                case 0:
                                    break;
                            }
                        } while (choose1 != 0);
                        break;
                    case 2:
                        int choose2;
                        do
                        {
                            Console.WriteLine("========================= MENU =======================");
                            Console.WriteLine("==1. Export the invoice list of customers VN        ==");
                            Console.WriteLine("==2. Export the invoice list of foreign customers   ==");
                            Console.WriteLine("==3. Export the invoice list of both                ==");
                            Console.WriteLine("==0. Exit                                           ==");
                            Console.WriteLine("======================================================");
                            Console.WriteLine("choose: ");
                            choose2 = int.Parse(Console.ReadLine());
                            switch (choose2)
                            {
                                case 1:
                                    Console.WriteLine("The invoice list of customers VN ");
                                    OutputCustomerVNList(customerVNList);
                                    break;
                                case 2:
                                    Console.WriteLine("The invoice list of foreign customer ");
                                    OutputFCustomerList(fCustomerList);
                                    break;
                                case 3:
                                    Console.WriteLine("The invoice list");
                                    Console.WriteLine("----------------------");
                                    OutputCustomerVNList(customerVNList);
                                    Console.WriteLine("----------------------");
                                    OutputFCustomerList(fCustomerList);
                                    break;
                                case 0:
                                    break;
                            }
                        } while (choose2 != 0);
                        break;
                    case 3:
                        Console.WriteLine("The invoice list of customer in September 2019 ");
                        OutputSep(customerVNList, fCustomerList);
                        break;
                    case 4:
                        if(KExceeded() == 0)
                        {
                            Console.WriteLine("No customer exceeded the norm.");
                        }
                        else
                        {
                            Console.WriteLine("KW exceeded the norm: {0}", KExceeded());
                        }
                        break;
                    case 5:
                        int choose3;
                        do
                        {
                            Console.WriteLine("========================= MENU =======================");
                            Console.WriteLine("==1. Find Id of VN customer and export bill         ==");
                            Console.WriteLine("==2. find id of foreign customer and export bill    ==");
                            Console.WriteLine("==0. Exit                                           ==");
                            Console.WriteLine("======================================================");
                            Console.WriteLine("choose: ");
                            choose3 = int.Parse(Console.ReadLine());
                            switch (choose3)
                            {
                                case 1:
                                    Console.WriteLine("Enter your Id find:  ");
                                    string id = Console.ReadLine();
                                    if (SearchID(id) == null)
                                    {
                                        Console.WriteLine("Id not exist or id wrong");
                                    }
                                    else
                                    {
                                        List<CustomerVN> customerVnResult = SearchID(id);
                                        Console.WriteLine("The bill of customers VN: {0}", id);
                                        OutputCustomerVNList(customerVnResult);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Enter your Id find:  ");
                                    string id1 = Console.ReadLine();
                                    if (SearchID(id1) == null)
                                    {
                                        Console.WriteLine("Id not exist or id wrong");
                                    }
                                    else
                                    {
                                        List<ForeignCustomer> foreignCustomerResult = SearchIDf(id1);
                                        Console.WriteLine("The bill of foreign customers: {0}", id1);
                                        OutputFCustomerList(foreignCustomerResult);
                                    }
                                    break;
                                case 0:
                                    break;
                            }
                        } while (choose3 != 0);
                        break;
                }
            } while (choose != 0);
        }
        private static void OutputCustomerVNList(List<CustomerVN> customerVNList)
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (CustomerVN item in customerVNList)

            {
                Console.WriteLine("--------");
                Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2}\n  Quantity: {3}\n  Cost: {4}\n  Object: {5}\n  Norm: {6}\n  Money: {7}", item.ID, item.FullName, item.Date, item.Quantity, item.Cost, item.Objectt, item.Norm, item.IntoMoney());
                Console.WriteLine("--------");
            }
        }

        private static void OutputFCustomerList(List<ForeignCustomer> fCustomerList)
        {
            // lap tung phan tu cua danh sach va in thong tin
            foreach (ForeignCustomer item in fCustomerList)

            {
                Console.WriteLine("--------");
                Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2}\n  Quantity: {3}\n Cost: {4}\n  Nationality: {5}\n  Money: {6}", item.ID, item.FullName, item.Date, item.Quantity, item.Cost, item.Nationality,item.IntoMoney());
                Console.WriteLine("--------");
            }
        }
        /// <param name="customerVNList"></param>
        /// <param name="fCustomerList"></param>
        private static void OutputSep(List<CustomerVN> customerVNList, List<ForeignCustomer> fCustomerList)
        {
            DateTime x,y;
            // lap tung phan tu cua danh sach va in thong tin
            foreach (CustomerVN item in customerVNList)
            {
                x = DateTime.Parse(item.Date);
                if (x.Month == 9 && x.Year == 2019)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2}\n  Quantity: {3}\n  Cost: {4}\n  Object: {5}\n  Norm: {6}\n  Money: {7}", item.ID, item.FullName, item.Date, item.Quantity, item.Cost, item.Objectt, item.Norm, item.IntoMoney());
                    Console.WriteLine("--------");
                }
            }
            foreach (ForeignCustomer item in fCustomerList)
            {
                y = DateTime.Parse(item.Date);
                if (y.Month == 9 && y.Year == 2019)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine("ID: {0}\n  FullName: {1}\n  Date:{2}\n  Quantity: {3}\n Cost: {4}\n  Nationality: {5}\n  Money: {6}", item.ID, item.FullName, item.Date, item.Quantity, item.Cost, item.Nationality, item.IntoMoney());
                    Console.WriteLine("--------");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// function exoprt the KW exceeded the norm
        /// </summary>
        /// <returns></returns>
        private static float KExceeded()
        { 
            float s = 0;  // gan bien tinh tong
            foreach (CustomerVN item in customerVNList)
            {
                if (item.Norm < item.Quantity)
                {
                     float x = item.Quantity - item.Norm;
                     s = s + x;
                }
            }
            return s;
        }
        /// <summary>
        /// find id and export the bill
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static List<CustomerVN> SearchID(string id)
        {
            return customerVNList.Where(s => s.ID.ToLower() == id.ToLower()).ToList();
        }

        private static List<ForeignCustomer> SearchIDf(string id)
        {
            return fCustomerList.Where(s => s.ID.ToLower() == id.ToLower()).ToList();
        }
    }
}
