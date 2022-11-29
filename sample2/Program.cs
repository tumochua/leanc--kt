using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample2
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Bai 2 ");
            /// khởi tạo đối tượng Program
            Program p = new Program();
            Console.WriteLine("Nhap so phan tu cua mang n = ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            if (sizeArray > 5)
            {
                int[] array = new int[sizeArray];
                for (int index = 0; index < sizeArray; index++)
                {
                    Console.Write("a[" + index + "] = ");
                    array[index] = Convert.ToInt32(Console.ReadLine());
                }
                p.displayArray(array);
                p.displayEven(array);
                p.checkArrayInNumber(array);
            }
            else
            {
                Console.WriteLine("Vui long nhap n > 5");
            }
            Console.ReadKey();
        }

        /// hàm hiển thị phần tử của mảng và không trả về giá trị vì có từ khóa 'void'
        void displayArray(int[] array)
        {
            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        /// hàm tính tổng và không trả về giá trị vì có từ khóa 'void'

        void displayEven(int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] % 2 == 0)
                {
                    sum += array[index];
                }
            }
            Console.WriteLine("\nTong so chan cua mang la: {0} ", sum);
        }
        /// hàm kiểm tra và không trả về giá trị vì có từ khóa 'void'

        void checkArrayInNumber(int[] array)
        {
            Console.WriteLine("\nNhap vao so can kiem tra: ");
            int number = int.Parse(Console.ReadLine());
            int check = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (number == array[index])
                {
                    Console.WriteLine("So vua nhap la so {0} co trong mang \nSo {1} o vi tri so {2} ", number, number, index);
                    check = 1;
                }

            }
            if (check != 1)
            {
                Console.WriteLine("\nSo vua nhap khong co trong mang ");
            }

        }


    }
}





