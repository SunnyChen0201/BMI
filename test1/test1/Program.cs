using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("┌────────────┐");
            Console.WriteLine("│                        │");
            Console.WriteLine("│                        │");
            Console.WriteLine("│          B M I         │");
            Console.WriteLine("│                        │");
            Console.WriteLine("│                        │");
            Console.WriteLine("└────────────┘");




            Console.WriteLine("輸入體重(公斤) : ");
            int KG = int.Parse(Console.ReadLine());
            Console.WriteLine("輸入身高(公尺) : ");
            double M = double.Parse(Console.ReadLine());
            double BMI = KG / (M * M);
            if (BMI >24)
                Console.WriteLine("您過重ㄌ"+"您的BMI:"+BMI);
            if (BMI<18.5)
                Console.WriteLine("您過輕ㄌ" + "您的BMI:" + BMI);


            else
                Console.WriteLine("正常" + "您的BMI:" + BMI);




            Console.ReadLine();
        }
    }
}
