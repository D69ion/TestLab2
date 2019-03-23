using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseCalculator;


namespace TestLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CalcClass.dll tests");
            CalcTest1();
            CalcTest2();
            Console.ReadLine();

            Console.WriteLine("AnalaizerClass.dll tests");
            AnalaizerTest1();
            AnalaizerTest2();
            AnalaizerTest3();
            AnalaizerTest4();
            Console.ReadLine();
        }

        private static void AnalaizerTest1()
        {
            Console.WriteLine("Test 1");
            AnalaizerClass.expression = "(1+(1+(1+(1+(1+1)))))";
            Console.WriteLine("Input data №1: " + AnalaizerClass.expression);
            Console.WriteLine("Expected result: true");
            bool result = AnalaizerClass.CheckCurrency();
            Console.WriteLine("Result: " + result);
            if (result)
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();

            Console.WriteLine("Test 2");
            AnalaizerClass.expression = "(1+(1+(1+(1+(1+1)))";
            Console.WriteLine("Input data: №2" + AnalaizerClass.expression);
            Console.WriteLine("Expected result: false");
            result = AnalaizerClass.CheckCurrency();
            Console.WriteLine("Result: " + result);
            if (!result)
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();
        }

        private static void AnalaizerTest2()
        {
            Console.WriteLine("Test 3");
            AnalaizerClass.expression = "1+1";
            Console.WriteLine("Input data №1: " + AnalaizerClass.expression);
            Console.WriteLine("Expected result: 1 + 1");
            string result = AnalaizerClass.Format();
            Console.WriteLine("Result: " + result);
            if (result.Equals("1 + 1"))
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();

            Console.WriteLine("Test 4");
            AnalaizerClass.expression = "1++1";
            Console.WriteLine("Input data №2: " + AnalaizerClass.expression);
            Console.WriteLine("Expected result: Error 04");
            result = AnalaizerClass.Format();
            Console.WriteLine("Result: " + result);
            if (result.Contains("Error 04"))
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();

            Console.WriteLine("Test 5");
            AnalaizerClass.expression = "!1";
            Console.WriteLine("Input data №3: " + AnalaizerClass.expression);
            Console.WriteLine("Expected result: Error 02");
            result = AnalaizerClass.Format();
            Console.WriteLine("Result: " + result);
            if (result.Contains("Error 02"))
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();

            Console.WriteLine("Test 6");
            StringBuilder str = new StringBuilder();
            for(int i = 0; i < 65536; i++)
            {
                str.Append('1');
            }
            str.Append("+1");
            AnalaizerClass.expression = str.ToString();
            Console.WriteLine("Input data №4: " + AnalaizerClass.expression);
            Console.WriteLine("Expected result: Error 07");
            result = AnalaizerClass.Format();
            Console.WriteLine("Result: " + result);
            if (result.Contains("Error 07"))
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();

            Console.WriteLine("Test 7");
            AnalaizerClass.expression = "1+";
            Console.WriteLine("Input data №5: " + AnalaizerClass.expression);
            Console.WriteLine("Expected result: Error 05");
            result = AnalaizerClass.Format();
            Console.WriteLine("Result: " + result);
            if (result.Contains("Error 05"))
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();

            Console.WriteLine("Test 8");
            AnalaizerClass.expression = "+1";
            Console.WriteLine("Input data №6: " + AnalaizerClass.expression);
            Console.WriteLine("Expected result: Error 05");
            result = AnalaizerClass.Format();
            Console.WriteLine("Result: " + result);
            if (result.Contains("Error 05"))
            {
                Console.WriteLine("Test complete");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
            Console.WriteLine();
        }

        private static void AnalaizerTest3()
        {

        }

        private static void AnalaizerTest4()
        {

        }

        private static void CalcTest1()
        {
            try
            {
                Console.WriteLine("Test 1\r\n" +
                    "Input data: a = 25, b = 25");
                Console.WriteLine("Expected result: 625");
                int result = CalcClass.Mult(25, 25);
                if (CalcClass.lastError == "")
                {
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("Test completed");
                }
                else
                {
                    Console.WriteLine("Error code: " + CalcClass.lastError);
                    Console.WriteLine("Test failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Test failed");
            }
        }

        private static void CalcTest2()
        {
            try
            {
                Console.WriteLine("Test 2\r\n" +
                    "Input data: a = , b = ");
                Console.WriteLine("Expected result: Error 06");
                int result = CalcClass.Mult((long)(int.MaxValue) * 2, 1);
                string str = CalcClass.lastError;
                if (str.Equals(""))
                {
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("Test completed");
                }
                else
                {
                    Console.WriteLine("Result: error");
                    Console.WriteLine("Error code: " + str);
                    Console.WriteLine("Test failed");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Test failed");
            }
        }
    
    }
}
