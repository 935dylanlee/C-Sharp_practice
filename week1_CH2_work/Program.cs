using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_CH2_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //這是2-1

            //Console.WriteLine("請輸入x值");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y值");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x>=y)
            //{
            //    Console.WriteLine($"因為x>=y,所以是{x}");
            //}
            //else
            //{
            //    Console.WriteLine($"因為x<y,所以是{y}");
            //}
            //Console.ReadKey();


            //這是2-2

            //Console.WriteLine("請輸入x值");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y值");
            //int y = Convert.ToInt32(Console.ReadLine());

            //if (x > 0 && y > 0) // 條件有兩者同時正數
            //{
            //    Console.WriteLine($"滿足條件z = 1");
            //}
            //else if (x < 0 && y < 0) // 條件有兩者同時負數
            //{
            //    Console.WriteLine($"滿足條件z = -1");
            //}
            //else
            //{
            //    Console.WriteLine($"其餘z = 0");
            //}
            //Console.ReadKey();


            //這是2-3

            //Console.WriteLine("請輸入x");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入u");
            //int u = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入v");
            //int v = Convert.ToInt32(Console.ReadLine());
            //int z;
            //if ((x + y) > (u + v))
            //{
            //    Console.WriteLine($"{z = x + y}");
            //}
            //else
            //{
            //    Console.WriteLine($"{z = u + v}");
            //}
            //Console.ReadKey();


            //是2-4

            //Console.WriteLine("請輸入x");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入y");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入u");
            //int u = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("請輸入v");
            //int v = Convert.ToInt32(Console.ReadLine());
            //int z;
            //if (((x + y) / (u + v)) >= 2)
            //{
            //    Console.WriteLine($"{z = x + y}");
            //}
            //else
            //{
            //    Console.WriteLine($"{z = u + v}");
            //}
            //Console.ReadKey();


            //是2-5

            //Console.WriteLine("請輸入x");
            //double x = Convert.ToDouble(Console.ReadLine()); //為了用math.pow轉成double
            //Console.WriteLine("請輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //double z;

            //if (x>=y)
            //{
            //    Console.WriteLine($"得到的是X的平方{z = Math.Pow(x,2)}");
            //}
            //else
            //{
            //    Console.WriteLine($"得到的是Y的的平方{z = Math.Pow(y, 2)}");
            //}
            //Console.ReadKey();


            //是2-6
            //Console.WriteLine("請輸入 income：");
            //double income = Convert.ToDouble(Console.ReadLine());

            //double rate;
            //double difference;
            //double tax;

            //if (income > 4090000) //這題如果把Console.WriteLine寫在if判斷裏面會導致tax = (income * rate) - difference 異常
            //{
            //    rate = 0.4;
            //    difference = 721000;
            //}
            //else if (income > 2180000)
            //{
            //    rate = 0.3;
            //    difference = 312100;
            //}
            //else if (income > 1090000)
            //{
            //    rate = 0.21;
            //    difference = 115900;
            //}
            //else if (income > 410000)
            //{
            //    rate = 0.13;
            //    difference = 28700;
            //}
            //else
            //{
            //    rate = 0.06;
            //    difference = 0;
            //}

            //tax = (income * rate) - difference; 
            //Console.WriteLine($"稅額：{tax}");

            //Console.ReadKey();


            //這是2-7
            //Console.WriteLine("請輸入x");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("請輸入y");
            //double y = Convert.ToDouble(Console.ReadLine());
            //if (x > 0)
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("1st quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("4th quadrant\n");
            //    }
            //}
            //else if (x == 0)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("Origin\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Y-axis\n");
            //    }
            //}
            //else
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("2nd quadrant\n");
            //    }
            //    else if (y == 0)
            //    {
            //        Console.WriteLine("X-axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("3rd quadrant\n");
            //    }
            //}

            //Console.ReadKey();


            //這裡是補充1 

            //Console.WriteLine("請輸入答對題數：");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int score;

            //if (n <= 10)
            //{
            //    score = 6 * n;
            //}
            //else if (n <= 20)
            //{
            //    score = 6 * 10 + 2 * (n - 10);
            //}
            //else if (n <= 40)
            //{
            //    score = 6 * 10 + 2 * 10 + 1 * (n - 20);
            //}
            //else
            //{
            //    score = 100;
            //}

            //Console.WriteLine($"統計後的分數為：{score}");
            //Console.ReadKey();

            //這裡是補充2

            Console.Write("請輸入身高（公分）：");
            double heightCm = Convert.ToDouble(Console.ReadLine());
            double height = heightCm / 100; // 將公分轉換為公尺
            Console.Write("請輸入體重（公斤）：");
            double weight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);
            Console.WriteLine($"你的BMI是: {bmi:F2}"); // 顯示到小數點後兩位

            if (bmi < 18.5)
            {
                Console.WriteLine("你的體重過輕");
            }
            else if (bmi < 24.9) // 不需要再次檢查 >= 18.5
            {
                Console.WriteLine("你的體重正常");
            }
            else if (bmi < 29.9) // 不需要再次檢查 >= 25
            {
                Console.WriteLine("你的體重過重");
            }
            else
            {
                Console.WriteLine("你的體重肥胖");
            }

            Console.ReadKey();

            //這裡是補充3

            //Console.Write("請輸入第一個數字：");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("請輸入第二個數字：");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("請輸入第三個數字：");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int largest, middle, smallest;
            //使用類似2-6 2-7的模式解
            //if (num1 >= num2 && num1 >= num3)
            //{
            //    largest = num1;
            //    if (num2 >= num3)
            //    {
            //        middle = num2;
            //        smallest = num3;
            //    }
            //    else
            //    {
            //        middle = num3;
            //        smallest = num2;
            //    }
            //}
            //else if (num2 >= num1 && num2 >= num3)
            //{
            //    largest = num2;
            //    if (num1 >= num3)
            //    {
            //        middle = num1;
            //        smallest = num3;
            //    }
            //    else
            //    {
            //        middle = num3;
            //        smallest = num1;
            //    }
            //}
            //else
            //{
            //    largest = num3;
            //    if (num1 >= num2)
            //    {
            //        middle = num1;
            //        smallest = num2;
            //    }
            //    else
            //    {
            //        middle = num2;
            //        smallest = num1;
            //    }
            //}

            //Console.WriteLine($"從大到小排序：{largest}, {middle}, {smallest}");
            //Console.ReadKey();


            //這裡是補充4

            //Console.Write("請輸入當月利潤（萬元）：");
            //double income = Convert.ToDouble(Console.ReadLine());

            //double bonus = 0;

            //if (income <= 10)
            //{
            //    bonus = income * 0.10;
            //}
            //else if (income <= 20)
            //{
            //    bonus = 10 * 0.10 + (income - 10) * 0.075;
            //}
            //else if (income <= 40)
            //{
            //    bonus = 10 * 0.10 + 10 * 0.075 + (income - 20) * 0.05;
            //}
            //else if (income <= 60)
            //{
            //    bonus = 10 * 0.10 + 10 * 0.075 + 20 * 0.05 + (income - 40) * 0.03;
            //}
            //else if (income <= 100)
            //{
            //    bonus = 10 * 0.10 + 10 * 0.075 + 20 * 0.05 + 20 * 0.03 + (income - 60) * 0.015;
            //}
            //else
            //{
            //    bonus = 10 * 0.10 + 10 * 0.075 + 20 * 0.05 + 20 * 0.03 + 40 * 0.015 + (income - 100) * 0.01;
            //}

            //Console.WriteLine($"發放的獎金總數是: {bonus} 萬元");
            //Console.ReadKey();

            //這裡是switch改寫：輸入一個學生的分數，輸出該成績級別

            //Console.Write("請輸入學生的分數：");
            //int score = Convert.ToInt32(Console.ReadLine());

            // 使用 switch 語句判斷成績級別
            //    switch (score / 10)
            //    {
            //        case 10:
            //        case 9:
            //            Console.WriteLine("成績級別：A");
            //            break;
            //        case 8:
            //            Console.WriteLine("成績級別：B");
            //            break;
            //        case 7:
            //            Console.WriteLine("成績級別：C");
            //            break;
            //        case 6:
            //            Console.WriteLine("成績級別：D");
            //            break;
            //        default:
            //            Console.WriteLine("成績級別：F");
            //            break;
            //    }
            //Console.ReadKey();
        }
    }
}
