using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Practice
{
    public class Employee
    {
        public string firstname;
        public string lastname;

        public string PrintFullName()
        {
            //Console.WriteLine("Name is :" + firstname +" "+ lastname);
            return firstname +" "+ lastname;


        }

        internal static IEnumerable<int> FindMissingNumber()
        {
            var list = new List<int>(new[] { 0, 1, 2, 3, 4, 6, 7, 8, 9,10,11,12,15 });
            var missingNumbers = Enumerable.Range(0, 16).Except(list);
            return missingNumbers;
        }


    }

    public class FullTimeEmployee : Employee
    {
       
        public FullTimeEmployee()
        {
            firstname = "Rehman";
            lastname = "Ali";
            salary = 100000;
        }
        
        public int salary;

    }

    public class PartTimeEmployee : Employee
    {

        public string hourlyrate;

    }

    public class TemporaryEMployee : Employee
    {

        public string hourlyrate;

    }




    class Program
    {
        static void Main()
        {

            FullTimeEmployee fulltime = new FullTimeEmployee();
            string FullName = fulltime.PrintFullName();

            Console.WriteLine("Employee :"+FullName+" "+"has Salary :"+" "+fulltime.salary);

            PartTimeEmployee partTime = new PartTimeEmployee();
            partTime.firstname = "Khaleel";
            partTime.lastname = "Ahmed";
            partTime.hourlyrate = "5 dollar";
            string PartTime = partTime.PrintFullName();

            Console.WriteLine("Employee :" + PartTime + " " + "has Salary :" + " " + partTime.hourlyrate);

            string[] Numbers = {"A","B","C","D","E","A","E" };
            string[] duplicates = Numbers.Distinct().ToArray();
            foreach (string Duplicate in duplicates)
            {
                Console.WriteLine(Duplicate);
            }

            var missingNumbers = Employee.FindMissingNumber();
            Console.WriteLine("Missing numbers in array are:\n");
            foreach (var num in missingNumbers)
            {
                Console.WriteLine(num);
            }

            int[] Missing_Number_Array = {1,2,3,5};
            var sequenced_array = Enumerable.Range(1,5);
            var sum_sequence = sequenced_array.Sum();
            Console.WriteLine("Sum of number is {0}",sum_sequence);
            var missing_number = Missing_Number_Array.Sum();
            Console.WriteLine("Sum of number is {0}", missing_number);
            int difference = sum_sequence - missing_number;
            Console.WriteLine("Missing Number is :{0}",difference);
            int temp;
            var a = Missing_Number_Array.Length;
            Console.WriteLine(a);
            //Sort an array in Descending Order
            for (int i = 0; i < Missing_Number_Array.Length; i++)
            {
                for (int j = i + 1; j < Missing_Number_Array.Length; j++)
                {
                    if (Missing_Number_Array[i] < Missing_Number_Array[j])
                    {
                        temp = Missing_Number_Array[i];
                        Missing_Number_Array[i] = Missing_Number_Array[j];
                        Missing_Number_Array[j] = temp;


                    }
                    // Console.WriteLine(Missing_Number_Array[i]);
                }
            }
            foreach (int value in Missing_Number_Array)
            {
                //Console.Write(value + " ");
            }

            //Reverse an Array
            //When indexed goes at the middle reverse operation has been completed
            
            string[] unreversed = {"A","B","C","D","E","F","G","H","I","J","K"};
            int q=unreversed.Length;
            int t = q / 2;
            var temp1 = "A";
            for(int i = 0;i<unreversed.Length;i++)
            {
                q = q - 1;
                for(int k=q;k<=q;k++)
                {
                    if (unreversed[k] != unreversed[i] && i != t)
                    {
                        temp1 = unreversed[i];
                        unreversed[i] = unreversed[k];
                        unreversed[k] = temp1;

                    }
                    else if (unreversed[k] == unreversed[i] && i != t)
                    {
                        temp1 = unreversed[i];
                        unreversed[i] = unreversed[k];
                        unreversed[k] = temp1;

                    }
                    else
                    {
                        goto printarray;

                    }
                    
                }
                
            }
            printarray:
            foreach (var k in unreversed)
            {
                Console.WriteLine(k);

            }

            //console.writeline("enter a number");
            //int number = int.parse(console.readline());

            //switch (number)
            //{
            //    case 10:
            //        console.writeline("your number is : {0}",number);
            //        break;
            //    case 20:
            //        console.writeline("your number is : {0}",number);
            //        break;
            //    case 30:
            //        console.writeline("your number is : {0}",number);
            //        break;


            //}



        }
    }
}          

      


        
    

