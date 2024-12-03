using System;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {

            #region part1
            #region problem1
            //string s = Console.ReadLine();
            //int x = int.Parse(s);
            //int y = Convert.ToInt32(s); 
            #endregion
            #region q1

            /*What is the difference between int.Parse and Convert.ToInt32 when 
            handling null inputs? 
            
            string s = null;
            int x = int.Parse(s);
            return exception because it works with just numeric strings 
            
            but

            int y=Convert.ToInt32(s);
            return 0 because it works with null values and string and some types
            */
            #endregion

            #region problem2
            //string s = Console.ReadLine();
            //int x;
            //bool flag = int.TryParse(s, out x);
            //if (flag == true)
            //{
            //    Console.WriteLine(x);
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //} 
            #endregion
            #region q2
            /*
                  Question: Why is TryParse recommended over Parse in user-facing applications? 
                answer:
                because if user  didnot enter numeric string it returns defalt value of integer "0"
                but parse returns error in the programme
                 */
            #endregion

            #region problem3
            //object obj = new object();
            // obj = "ahmed";
            // Console.WriteLine(obj.GetHashCode());
            // obj = 'a';
            // Console.WriteLine(obj.GetHashCode());
            // obj = 4;
            // Console.WriteLine(obj.GetHashCode()); 
            #endregion
            #region q3
            /*
                  Question: Explain the real purpose of the GetHashCode() method. 
                    it generates a unique code for objects . it helps to location the object address
                 */
            #endregion






            #region problem5
            //string s = "Hi ";
            //Console.WriteLine(s.GetHashCode());//-1871866221
            //s += "Willy";
            //Console.WriteLine(s.GetHashCode());//-500922069 
            #endregion
            #region q5
            /*Why string is immutable in C# ?
               because it cannot be changed or added any char in it
               it factully create a new string and add changes on it

               */
            #endregion

            #region problem6
            //StringBuilder s = new StringBuilder("Hi ");
            //Console.WriteLine(s.GetHashCode());//58225482
            //s = s.Append("Willy");
            //Console.WriteLine(s.GetHashCode());//58225482 
            #endregion
            #region q6
            /*

                  Question: How does StringBuilder address the inefficiencies of string concatenation? 

                 answer:

                 It addresses the inefficiencies of the traditional string 
                concatenation process by avoiding the creation of multiple string objects in memory.
                 */

            #endregion


            #region q7
            /*
                  Question: Why is StringBuilder faster for large-scale string modifications? 
                because it avoides createing a new string and edit in tradirional string fast


                 */
            #endregion

            #region problem7
            //int x=int.Parse (Console.ReadLine());
            //int y =int.Parse( Console.ReadLine());

            // Console.WriteLine("res : " + x + " + " + y + " = " + (x + y));
            // string massege = string.Format("res : {0} + {1} = {2} ", x, y, x + y);
            // Console.WriteLine(massege);
            // string mas = $"res : {x} + {y} = {x + y}";
            // Console.WriteLine(mas); 
            #endregion
            #region q8
            // Question: Which string formatting method is most used and why? 
            // the third
            // because it more readable and produces efficient intermediate code.

            #endregion

            #region problem8
            //StringBuilder sb = new StringBuilder("ahmed");
            //sb = sb.Append(" gamal");
            //Console.WriteLine(sb);
            //sb = sb.Replace("gamal", "abdo");
            //Console.WriteLine(sb);
            //sb = sb.Insert(6, "ali ");
            //Console.WriteLine(sb);
            //sb = sb.Remove(2, 6);
            //Console.WriteLine(sb); 
            #endregion
            #region q9
            /*
                stringbuiledr>>linkedlist>>donnot make any new copies so that will be recommended in texts that chanes alot
                */
            #endregion 


            #endregion



            #region part2
            /*
                  What’s Enum data type, when is it used? And name three common built_in enums used 
                    frequently

                answer:
                 Enum is a value type used to define a set of named constants, improving code readability and reduce errors
                It is good for scenarios where you need a fixed set of related values.
                  Common Built-in Enums:
                        NumberStyles
                        DayOfWeek
                        StringComparison




                 3- what are scenarios to use  string Vs StringBuilder?
                answer:

                    if we have mutable text or litte of change use string
                else use stringbuilder
                 */
            #endregion










        }
    }
}
