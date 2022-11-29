using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bai 3");
            Console.WriteLine("Nhap 1 xau bat ky: ");
            string str = Console.ReadLine();
            Console.WriteLine("Xau vua nhap la:\n{0}", str);
            Console.WriteLine("Nhap vao mot xau bat ky de kiem tra: ");
            string kt = Console.ReadLine();
            string[] arr = str.Split();
            string[] ktrr = kt.Split();
            int check = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < ktrr.Length; j++)
                {
                    if (arr[i] == ktrr[j])
                    {
                        check += 1;
                    }
                }
            }
            if (check > 0)
            {
                Console.WriteLine("Xau vua nhap vao co trong xau da nhap dau tien");

            }
            else
            {
                Console.WriteLine("Xau vua nhap vao khong co trong xau da nhap dau tien");
            }
            Console.WriteLine("tu {0} xuat hien {1} lan ", kt, check);
            Console.ReadKey();
        }

    }
}



