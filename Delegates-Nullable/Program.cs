using Delegates_Nullable.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_Nullable
{
    class Program
    {
       
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str,int age);

        //public delegate int StringLength(string str);

        static void Main(string[] args)
        {
            #region Classwork
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(SumOfNumber(CheckOddNums, arr));
            //Console.WriteLine(SumOfNumber(CheckEvenNums, arr));
            //Console.WriteLine(SumOfNumber(CheckGreaterThanFour, arr));


            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = nums.FindAll(CheckGreaterThanFour);
            //Console.WriteLine(result.Count);

            //var result1 = nums.FindAll(m => m % 2 == 0 && m > 5);
            //Console.WriteLine(result1.Count);


            //List<int> list = new List<int> {12,21,42,63,14 };

            //Console.WriteLine(SumOfNumbers(CheckNumbers,list));



            //string name = "Nihad";
            //int age = 20;
            //ShowString(StringToLower, name,age);
            //ShowString(StringToUpper, name,age);



            //Action<string,int> func= new Action<string,int>(StringToLower);
            //func += StringToUpper;                      

            //func += delegate (string str, int age)
            //  {
            //      Console.WriteLine(str.ToUpper()+"-Age :" +age);
            //  };

            //func.Invoke("Anar", 35);

            //PowerOfNumber(CalculatePower, 2, 5);
            //Action<int, int> action = CalculatePower;
            //action.Invoke(4, 3);


            //ShowStringLength(GetStringLength, "Gultac");

            //Func<string, int> func = GetStringLength;
            //Console.WriteLine(func.Invoke("Lale"));

            //Func<int, int> func = Factorial;
            //Console.WriteLine(func.Invoke(5));

            //Console.WriteLine(CalculationOfFactorial(Factorial,5));
            #endregion


            #region SalaryGreaterThan

            List<Person> person = new List<Person>();
            person.Add(new Person(750, "Ziya", "Nasirov", "Azadliq str"));
            person.Add(new Person(500, "Rustam", "Safarov", "Nasimi str"));
            person.Add(new Person(1600, "Samaya", "Taghiyeva", "28 may str"));
            person.Add(new Person(800, "Ulviyya", "Sadigova", "Gunesli"));

            Console.WriteLine(Person(CheckPersons, person));
            #endregion


            #region CountOfBook                       
            List<Book> books = new List<Book>();
            books.Add(new Book("Khosrow and Shirin", "Nizami"));
            books.Add(new Book("The Godfather", "Mario Puzo"));
            books.Add(new Book("The Minds of Billy Milligan", "Daniel Keyes"));
            books.Add(new Book("Makhzan al-Asrar", "Nizami"));
            Console.WriteLine(Books(CheckBook,books));
            #endregion


           
            #region AverageOfEmployeSalary

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(25, 2300));
            employees.Add(new Employee(19, 700));
            employees.Add(new Employee(45, 1600));
            employees.Add(new Employee(22, 2500));
            Console.WriteLine();

            
            #endregion




        }


        public static bool CheckPersons(Person person)
        {
            return  person.Salary> 1000;
        }

        public static string Person(Predicate<Person> predicate, List<Person> person)
        {
            
            foreach (var item in person)
            {
                if (predicate(item))
                {
                    return item.Name+" "+item.SurName+" "+item.Address;
                }           

            }
            return "";
            
        }


        public static bool CheckBook(Book book)
        {
            if (book.BookAuthor=="Nizami")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Books(Predicate<Book> predicate,List<Book> book)
        {
            int count = 0;
            foreach (var item in book)
            {
                if (predicate(item))
                {
                    count++;
                }
            }
            return count;
        }




        public static void Employee(Employee employee)
        {
            int count = 0;
            int avg = 0;
            int sum = 0;
            if (employee.Age > 20 && employee.Age > 40)
            {
                count++;
                _ = employee.Salary;
                avg = (int)employee.Salary / count;
            }
            Console.WriteLine(avg);
        }


        //public static void CheckEmployee(Action<Employee> action, List<Employee> emp)
        //{
        //    return action(emp);
        //}


        #region ClassWork



        //public static bool CheckOddNums(int number)
        //{
        //    return number % 2 != 0;
        //}


        //public static bool CheckEvenNums(int number)
        //{
        //    return number % 2 == 0;
        //}


        //public static bool CheckGreaterThanFour(int number)
        //{
        //    return number > 4;
        //}

        //public static int SumOfNumber(Predicate<int> predicate, int[] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}


        //public static bool CheckNumbers(int number)
        //{
        //    return number % 3 == 0 && number % 7 == 0;
        //}


        //public static int SumOfNumbers(Predicate<int> predicate, List<int> list)
        //{
        //    int sum = 0;
        //    foreach (var item in list)
        //    {
        //        if (predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}



        //public static void StringToLower(string str, int age)
        //{
        //    Console.WriteLine(str.ToLower() + "-" + age);
        //}

        //public static void StringToUpper(string str, int age)
        //{
        //    Console.WriteLine(str.ToUpper() + "-" + age);
        //}

        //public static void ShowString(Action<string, int> func, string str, int age)
        //{
        //    func(str, age);
        //}

        //public static void CalculatePower(int num1, int pow)
        //{
        //    Console.WriteLine(Math.Pow(num1, pow));
        //}

        //public static void PowerOfNumber(Action<int, int> func, int num, int power)
        //{
        //    func(num, power);
        //}


        //public static int GetStringLength(string str)
        //{
        //    return str.Length;
        //}



        //public static void ShowStringLength(Func<string, int> func, string word)
        //{
        //    Console.WriteLine(func(word));
        //}



        //public static int Factorial(int nums)
        //{
        //    int factorial = 1;
        //    if (nums < 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        for (int i = nums; i >= 2; i--)
        //        {
        //            factorial = factorial * i;
        //        }
        //        return factorial;
        //    }
        //}

        //public static int CalculationOfFactorial(Func<int, int> func, int num)
        //{
        //    return func(num);
        //}
        #endregion

    }








}
