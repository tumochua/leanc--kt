using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bai 1 ");
            Console.WriteLine("Nhap vao n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 2)
            {
                Console.WriteLine("Hinh a \n");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j <= i)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }

                    }
                    Console.Write("\n");
                }
                for (int i = 1; i <= n - 1; i++)
                {
                    for (int j = 1; j <= n - 1; j++)
                    {
                        if (j <= n - i)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }

                    }
                    Console.Write("\n");
                }
                Console.WriteLine("\n\n");

                Console.WriteLine("Hinh b \n");
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (j <= n - i)
                        {
                            Console.Write("   ");
                        }
                        else
                        {
                            Console.Write(" * ");
                        }

                    }
                    Console.Write("\n");
                }
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j <= n - 1; j++)
                    {
                        if (j >= i)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }

                    }
                    Console.Write("\n");
                }
                Console.WriteLine("\n\n");
            }
            Console.ReadKey();
        }

    }
}



