using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexday2
{ public class Emp
    {
        public void cal(int wh=0 , int wd=0 , int h =1 , int e = 0)
        {
            Console.WriteLine($"Salary is{(wh * wd * 100) + (h * 3000) + (e * 20000)}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)

        {
            Emp emp = new Emp();
            Console.WriteLine("Enter employee type");
            string name= Console.ReadLine();
            switch (name)
            {
                case "HR":
                    {
                        Console.WriteLine("Enter working hrs and working days for HR");
                        int a= int.Parse(Console.ReadLine());
                        int b= int.Parse(Console.ReadLine());
                        emp.cal(a, b);
                    }
                    break;
                case "ADMIN":
                    {
                        Console.WriteLine("Enter working hr , working days and project handle for admin");
                        int a= int.Parse(Console.ReadLine()) ;
                        int b = int.Parse(Console.ReadLine());
                        int c= int.Parse(Console.ReadLine());
                        emp.cal(a, b, c);

                    }break;
                case "SDE":
                    {
                        Console.WriteLine("Enter working hrs, working days, project handles and extras for sde");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        int d = int.Parse(Console.ReadLine());
                        emp.cal(a,b,c,d);
                              
                    }break;
                    default:
                    {
                        Console.WriteLine("Type not found");
                    }break;
                    
            }
            Console.ReadKey();
        }
    }
}
