using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01
{

    /*
     * 
    题目要求：实现一个控制台小游戏
    1. 类A有三个私有成员变量min，max和num，只能给num以属性的方式定义一个get方法来获得num的值。
    2. 给类A定义一个有参的构造函数，可以通过参数给max和min赋值，然后根据max和min生成一个随机数赋值给num。（max和min分别对应生成随机的最大值和最小值）
    3. 用户猜测次数规定最多只能猜测5次，如果5次仍然未猜中，则退出程序。如果在其中的某一次猜中了，也会退出程序。
     *
    */


    class HomeWork01
    {
        

        static void Main(string[] args)
        {   
            // Variable for input numbers.
            int num1, num2;
            int max, min;

            // To store the returned value from Class A.
            int num;
            // Varialbe for the guessing number.
            int inputNumber;
            // Count the guessing times.
            int count = 1;

            // Get the initiate 2 integer.
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter two differen integers.");
                    Console.WriteLine("Please enter the 1st integer:");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter the 2nd integer:");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    // Get the max and min numbers.
                    if (num1 == num2)
                    {
                        Console.WriteLine("The two integers are the same. Please try again.\n");
                    }
                    else if (num1 < num2)
                    {
                        max = num2;
                        min = num1;
                        break;
                    }
                    else
                    {
                        max = num1;
                        min = num2;
                        break;
                    }

                }
                catch
                {

                    Console.WriteLine("Please enter the numbers (integers) only.");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Please enter the number (integer) you guess.");
            Console.WriteLine("The number is between{0} and {1}", min, max);
            Console.WriteLine("You have 5 times to win the game. Let's start!");

            // Class A instance. Get the num for guessing.
            A a = new A(min, max);
            num = a.GetNum();

            // Game. 5 tries for user.
            do
            {

                try
                {
                    Console.WriteLine("Try {0}:", count);
                    inputNumber = Convert.ToInt32(Console.ReadLine());
                    // If the user gets the correct number, exit application.
                    if (inputNumber == num)
                    {
                        Console.WriteLine("Congratulation! You win!");
                        Console.ReadKey();
                        Environment.Exit(1);
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Incorrect input. Please try again. You have {0} tries/try left.",5-count);
                }

                count++;

            } while (count <=5);

            // Show this message if user does not get the "num".
            Console.WriteLine("Sorry, you loose.");
            Console.ReadKey();

        }

    }



    class A
    {/// <summary>
     /// Class A: Return an random integer between min and max.
     /// </summary>
        private int _min, _max, _num;

        public A(int min, int max)
        {
            _max = max;
            _min = min;
            Random num = new Random();
            _num = num.Next(_min, _max);
        }

        public int GetNum()
        {
            return _num;
        }


    }

}
