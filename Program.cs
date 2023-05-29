

using System; // #include<iostream>
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Project1
{
    internal class Program
    {
        // Struct
        struct stStudent
        {
            public string FirstName;
            public string LastName;
        }
        //Enum
        enum enWeekDays
        {
            Monday,     // 0
            Tuesday,    // 1
            Wednesday,  // 2
            Thursday,   // 3
            Friday,     // 4
            Saturday,   // 5
            Sunday      // 6
        }

        //if you set a value , it will auto number everything after it.
        enum enCategories
        {
            Electronics,    // 0
            Food,           // 1
            Automotive = 6, // 6
            Arts,           // 7
            BeautyCare,     // 8
            Fashion         // 9
        }


        //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
        //but not string
       
        enum enCategories2 : byte
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15
        }

        static void PrintMyName()
        {
            Console.WriteLine("Omer Memes");
        }

        static string GetMyName() 
        {
            Console.WriteLine("Enter Your Name: ");
            return Console.ReadLine();
        }

        static void PrintMyName(string Name, string Surname)
        {
            Console.WriteLine(Name + " " + Surname);
        }

        static void PrintMyName(string Name, string MiddleName, string Surname="Memes")
        {
            Console.WriteLine(Name + " " + MiddleName + " " + Surname);
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello in first project in C# :-)");
            Console.ReadLine(); // bunu ekelmezsek ekran direkt kapanacak

            // library: هي مجموعة من الفانكشنز موجودة في كلاس أو فانكشنز الحرة
            // Framework: هي مجموعة من المكتبات والقوانين التي تقيدنا كمبرمجين في طريقة كتابة الكود
            // Platform: hardware | software  هي البيئة التي يتم العمل عليها قد تكون 
            // .Net = Platform = Programming Language + Libraries
            // Net is a Platform
            // .Net Framework: Websites, Services and Desktop apps... etc on Windows
            // .Net Core: (run anywhere) Windows, Linux, and macOS

            // Machine Code بتحويل الكود الذي نستخدمه الآن إلى JIT بعدها يقوم الـ  CIl الكومبايلر بحوله إلى لغة وسطية C# عند كتابة كود في لغة 

            // JIT = Just In Time   تحويل الكود المطلوب فقط من قبل الكومبايلر || بطيئ في أول مرة 
            // AOT = AHead Of Time  تحويل كل البنامج من قبل الكومبايلر 
            // CLR : JİT يقوم بتحويل الكود المدخل من لغة متوسطة إلى إلى لغة الآلة عن طريق الـ

            // CLR: Common Language RunTime 
            // It Convert the program to into native language.
            // Handles Exceptions.
            // Provides type-safety.
            // Memory management.
            // Improved performance
            // Language independent.
            // Platform independent.
            // Garbage collection.
            // Provides language feature such inheritance, interface, and overloading for object-oriented programs.
            // Manager for all .NET supported languages


            // ------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Hello World! ");

            Console.WriteLine("Result of 10 + 20 is " + (10 + 20));
            Console.WriteLine("Result of 10 + 20 is " + 10 + 20); // Concatination =>  Result of 10 + 20 is 1020

            // Escape Characters
            // New Line
            Console.WriteLine("Omer Memes\nFrom Syria"); // Like C++ 
            // Alret
            Console.WriteLine("Omer Memes\a From Syria"); // Like C++ 
            // Tab
            Console.WriteLine("Omer Memes\tFrom Syria"); // Like C++
            // Tab
            Console.WriteLine("Omer Memes\tFrom Syria"); // WriteLine يطبع بشكل مباشر على سطر جديد
            // Back Space
            Console.WriteLine("Omer Memes\b  From Syria"); // WriteLine يطبع بشكل مباشر على سطر جديد
            // Double Quote
            Console.WriteLine("Omer MEMES From \"Syria\"");
            // Single Quote
            Console.WriteLine("Omer MEMES From \'Syria\'");

            Console.Write("Hello My Name Is Omer Memes...\n"); //new line هنا يجب استخدام 
            Console.Write("I am from Syria...\n");
            Console.Write("But My Grandfather is From Turkey...\n");

            Console.WriteLine("{0} {1} {2} {3}", "Omer", "Ahmed", "Omer", "Memes"); // Omer Ahmed Omer Memes

            int x = 10, y = 20;
            int Result = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, Result); // 10 + 20 = 30

            Console.ReadKey(); // system("pause > 0") in C++

            // ------------------------------------------------------------------------------------------------------------------------

            // Comment in C#

            /*
               Comments in C#
               Comments in C#
               Comments in C#
            */

            // ------------------------------------------------------------------------------------------------------------------------

            // Variables
            int X = 10;
            int Y = 20;

            double Z = 1554;
            double R = 12.43;
            double Q = 12.43D;
            char A = 'a';
            string FullName = "omer memes";

            Console.WriteLine("{0} + {1} = {2}", X, Y, X + Y);
            Console.WriteLine("{0} + {1} + {2} = {3}", Z, R, Q, Z + R + Q);
            Console.WriteLine("My Name is : " + FullName);
            Console.WriteLine("{0}".ToUpper(), A);


            int @string = 3;
            string @break = "omer";

            Console.WriteLine(@string);
            Console.WriteLine(@break);

            // Implicitly Variable Like Auto In C++ متغير ضمني
            // Variable declared using var keyword must be initialized at the time of declaration
            // يجب أن يأخذ قيمة ابتدائية إلا سنحصل على خطأ
            var v1 = 12;
            var v2 = 12.3;
            var v3 = "OMS";
            var v4 = 'V';

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);


            //byte b1 = -128; // Error Compile-Time || Cannot Allows Nigative
            sbyte b3 = -128; 
            byte b2 = 255;

            short s1 = 32767;
            short s2 = -32768;
            //short s3 = 35000; // Error 
            ushort s4 = 65535; // لا تقبل سالب

            int i1 = 4342;
            int i2 = -4342;
            //uint i3 = -4342; // لا يقبل سالب
            uint i3 = 694342;

            float f1 = 1342.43f;
            double d1 = 1342.43D;

            decimal d2 = 55555555555; // أكبر حجم بيانات
            decimal d3 = 55555555555.555555M; // أكبر حجم بيانات

            double d4 = 0.32e2D; // 0.32 * 100;
            float f5 = 123.45e-2F; // 1.2345
            decimal d5 = 1.2e6M; // 1200000

            Console.WriteLine("{0} {1}", decimal.MaxValue, decimal.MinValue);
            Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);
            Console.WriteLine("{0} {1}", int.MaxValue, int.MinValue);
            Console.WriteLine("{0} {1}", double.MaxValue, double.MinValue);
            Console.WriteLine("{0} {1}", short.MaxValue, short.MinValue);
            Console.WriteLine("{0} {1}", ushort.MaxValue, ushort.MinValue);

            ------------------------------------------------------------------------------------------------------------------------

            // Default Value
            // Every data type has a default value.Numeric type is 0, boolean has false, and char has '\0' as default value.
            // /  Use the default(typename) to assign a default value of the data type
            int x = default(int);
            int y = default(int);
            double q = default(double);
            float z = default;
            char r = default;
            string p = default;

            Console.WriteLine(x);
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(q);
            Console.WriteLine(r);
            Console.WriteLine(p);

            ------------------------------------------------------------------------------------------------------------------------

            // Enum
            enWeekDays Dayes;
            Dayes = enWeekDays.Friday;
            Console.WriteLine(Dayes);  // Friday
            Console.WriteLine((int)Dayes);  // 4

            enCategories Category;
            //Console.WriteLine(Category); you cannot print like this
            Category = enCategories.Food;
            Console.WriteLine(Category);  // Food
            Console.WriteLine((int)Category); // 1

            enCategories2 Category2;
            Category2 = enCategories2.BeautyCare;
            Console.WriteLine(Category2); // BeautyCare
            Console.WriteLine((int)Category2); // 11


            ------------------------------------------------------------------------------------------------------------------------

            //Nullable Types
            // As you know, a value type cannot be assigned a null value.For example, 
            // int i = null will give you a compile time error.

            // C# 2.0 introduced nullable types that allow you to assign null to value type variables. 
            //You can declare nullable types using Nullable<t> where T is a type.

            //  Nullable<int> can be assigned any value
            //  from -2147483648 to 2147483647, or a null value.

            Nullable<int> i = null;
            Nullable<double> j = null;
            Console.WriteLine(i); // null
            Console.WriteLine(j); // null

            i = 43;
            j = 43.66D;
            Console.WriteLine(i); // 43
            Console.WriteLine(j); // 43.66

            ------------------------------------------------------------------------------------------------------------------------

            //Anonymous Type
            //In C#, an anonymous type is a type (class) without any name that can contain public read-only properties only. 
            //It cannot contain other members, such as fields, methods, events, etc.

            var student = new { Id = 123, Name = "omer", Surname = "Memes", Age = 23 };
            // You can print like this
            Console.WriteLine(student); // { Id = 123, Name = omer, Surname = Memes, Age = 23 }
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);

            //anonymous types are read-only
            //you cannot change the values of properties as they are read-only.
            //student.Id = 2;//Error: cannot chage value
            //student.FirstName = "Ali";//Error: cannot chage value

            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
               Id = 20,
               FirstName = "Omer",
               LastName = "Memes",
               Address = new { Id = 31, City = "Hatay", Country = "Turkey" }
            };
            Console.WriteLine(student2);
            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);

            ------------------------------------------------------------------------------------------------------------------------

            // Struct
            //A struct object can be created with or without the new operator,
            //same as primitive type variables.
            stStudent Student;
            Student.FirstName = "Omer";
            Student.LastName = "Memes";

            //Console .WriteLine(Student); // Project1.Program+stStrudent
            Console .WriteLine(Student.FirstName);  // Omer
            Console .WriteLine(Student.LastName); // Memes

            stStudent Student2 = new stStudent();
            Student2.FirstName = "omer";
            Student2.LastName = "memes";
            Console .WriteLine(Student2.FirstName);
            Console .WriteLine(Student2.LastName);

            //------------------------------------------------------------------------------------------------------------------------

            dynamic MyDynamicVar; //  بأن قابل للتعريف بدون قيمة ابتدائية var يختلف عن الـ
            MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            //------------------------------------------------------------------------------------------------------------------------

            // C# includes DateTime struct to work with dates and times.
            DateTime DT = new DateTime();
            Console.WriteLine(DT.ToString()); // 1/1/0001 12:00:00 AM

            DateTime DT2 = DateTime.Now;
            Console.WriteLine(DT2.ToString()); // 5/28/2023 3:03:05 PM

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            // القراد
            DateTime dt = new DateTime();
            Console.WriteLine(DateTime.MinValue.Ticks);  //min value of ticks
            Console.WriteLine(DateTime.MaxValue.Ticks); // max value of ticks

            DateTime dt1 = DateTime.Now;
            DateTime dt2 = DateTime.Today;
            int dt3 = DateTime.DaysInMonth(2023, 5);
            DateTime dt4 = DateTime.MaxValue;
            DateTime dt5 = DateTime.MinValue;
            DateTime dt6 = DateTime.UtcNow;

            Console.WriteLine("currentDateTime: " + dt1);
            Console.WriteLine("Today: " + dt2);
            Console.WriteLine("currentDateTimeUTC: " + dt6);
            Console.WriteLine("minDateTimeValue: " + dt5);
            Console.WriteLine("maxDateTimeValue: " + dt4);
            Console.WriteLine("Month Count Days: " + dt3);

            //TimeSpan is a struct that is used to represent time in days, hour, minutes, seconds, and milliseconds.

            TimeSpan TS = new TimeSpan(49, 25, 34);
            Console.WriteLine("Time: "+ TS);
            Console.WriteLine("Hour: " + TS.Hours);
            Console.WriteLine("Minutes: "+ TS.Minutes);
            Console.WriteLine("Seconds: "+ TS.Seconds);

            DateTime dt7 = new DateTime(2023, 5, 28);
            DateTime NewDateTime = dt7.Add(TS);
            Console.WriteLine("New Date Time: {0}", NewDateTime);

            DateTime dt1 = new DateTime(2023, 2, 21);
            DateTime dt2 = new DateTime(2023, 5, 25);
            TimeSpan result = dt2.Subtract(dt1);
            Console.WriteLine(result.Days);


            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt2 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt2 - dt1); //377.05:10:20
            Console.WriteLine(dt1 == dt2); //False
            Console.WriteLine(dt1 != dt2); //True
            Console.WriteLine(dt1 > dt2); //False
            Console.WriteLine(dt1 < dt2); //True
            Console.WriteLine(dt1 >= dt2); //False
            Console.WriteLine(dt1 <= dt2);//

            var str = "6/12/2023";
            DateTime dt;

            var isValidDate = DateTime.TryParse(str, out dt);

            if (isValidDate)
               Console.WriteLine(dt);
            else
               Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime dt2;

            var isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
               Console.WriteLine(dt2);
            else
               Console.WriteLine($"{str2} is not a valid date string");


            //------------------------------------------------------------------------------------------------------------------------

            //// Strings
            string S1 = "Omer Ahmed Omer Memes";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Ali,Ahmed,Omer";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Omer-MEMES  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());


            ////  String Interpolation
            string Name = "Omer";
            string Surname = "MEMES";
            string Username = "oms83";
            int ID = 4444;
            string Info = $"Mr.{Name} {Surname} Username.{Username} ID.{ID}";
            Console.WriteLine(Info);

            //------------------------------------------------------------------------------------------------------------------------

            //Implicit Casting (automatically) - converting a smaller type to a larger type size
            //char -> int -> long -> float -> double

            //Explicit Casting (manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            int myInt = 17;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 17
            Console.WriteLine(myDouble);   // Outputs 17

            double myDouble1 = 17.58;
            int myInt1 = (int)myDouble1;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 17.58
            Console.WriteLine(myInt1);      // Outputs 17

            //It is also possible to convert data types explicitly by using built-in methods, such as 
            / Convert.ToBoolean, Convert.ToDouble, Convert.ToString, 
            / Convert.ToInt32(int) and Convert.ToInt64(long)



            Console.WriteLine(enWeekDays.Friday);

            int Day = (int)enWeekDays.Friday;
            Console.WriteLine(Day);

            var wd = (enWeekDays)6;
            Console.WriteLine(wd);

            //------------------------------------------------------------------------------------------------------------------------


            ////Get User Input

            Console.WriteLine("Please Enter Your Username: ");
            string UserName = Console.ReadLine();
            Console.WriteLine(UserName);

            Console.WriteLine("Please Enter your ID: ");
            int ID  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ID);


            //------------------------------------------------------------------------------------------------------------------------

            ////Unary Operators

            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));

            //------------------------------------------------------------------------------------------------------------------------

            //SWITCH

            string Name = "Mohammed";

            //You can compare string as well using switch
            switch (Name.ToLower())
            {
               case "mohammed":

                   Console.WriteLine("Yes Mohammed");
                   break;

               case "ali":

                   Console.WriteLine("Yes ALi");
                   break;

               default:
                   Console.WriteLine("No Name Matched!");
                   break;

            }

            char op;
            double first, second, result;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
               case '+':
                   result = first + second;
                   Console.WriteLine("{0} + {1} = {2}", first, second, result);
                   break;

               case '-':
                   result = first - second;
                   Console.WriteLine("{0} - {1} = {2}", first, second, result);
                   break;

               case '*':
                   result = first * second;
                   Console.WriteLine("{0} * {1} = {2}", first, second, result);
                   break;

               case '/':
                   result = first / second;
                   Console.WriteLine("{0} / {1} = {2}", first, second, result);
                   break;

               default:
                   Console.WriteLine("Invalid Operator");
                   break;

            }

            char ch;
            Console.WriteLine("Enter a letter");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
               case 'a':
               case 'e':
               case 'i':
               case 'o':
               case 'u':
                   Console.WriteLine("Vowel");
                   break;
               default:
                   Console.WriteLine("Not a vowel");
                   break;
            }

            char ch;
            Console.WriteLine("Enter a letter?");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
               case 'a':
                   Console.WriteLine("Vowel");
                   break;
               case 'e':
                   Console.WriteLine("Vowel");
                   break;
               case 'i':
                   Console.WriteLine("Vowel");
                   break;
               case 'o':
                   Console.WriteLine("Vowel");
                   break;
               case 'u':
                   Console.WriteLine("Vowel");
                   break;
               default:
                   Console.WriteLine("Not a vowel");
                   break;
            }

            //------------------------------------------------------------------------------------------------------------------------

            LOOPS

            int number = 43;
            bool isEven;

            if (number % 2 == 0)
            {
               isEven = true;
            }
            else
            {
               isEven = false;
            }

            isEven = (number % 2 == 0) ? true : false;


            Console.WriteLine("\nForward Loop:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {

               Console.WriteLine(i);

            }

            Console.WriteLine("\nBackword Loop:");
            //backword loop
            for (int i = 10; i >= 1; i--)

            {

               Console.WriteLine(i);

            }


            Console.WriteLine("\nNested Loops:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {

               for (int j = 0; j < 10; j++)

               {

                   Console.WriteLine("i={0} and j={1}", i, j);

               }

            }

            int i = 1;
            while (i <= 5)
            {
               Console.WriteLine("C# while Loop: Iteration {0}", i);
               i++;
            }

            int i = 1;
            do
            {
               Console.WriteLine("C# while Loop: Iteration {0}", i);
               i++;

            } while (i <= 5);

            //------------------------------------------------------------------------------------------------------------------------

            // Arrays 
            //Arrays are bound, you cannot exceed their limits as you do in C++

            int[] Array = { 1, 2, 3, 4, 5, 6 };
            //Array[6] = 4; ERROR


            int[] age;
            //Here, we have created an array named age.It can store elements of int type.

            //But how many elements can it store?


            //To define the number of elements that an array can hold, we have to allocate memory for the array in C#. For example,
            // declare an array

            // allocate memory for array
            age = new int[5];
            //Here, new int[5] represents that the array can store 5 elements.We can also say the size/ length of the array is 5.

            //Note: We can also declare and allocate the memory of an array in a single line.For example,

            int[] Age = new int[5];

            int[] Numbers = { 1, 2, 3, 4, 5, 6 };

            Numbers[0] = 43;
            Numbers[2] = 431;
            Numbers[3] = 234;
            Numbers[1] = 55;

            for(int i=0; i<Numbers.Length; i++)
            {
               Console.WriteLine(Numbers[i]);
            }

            //An array index always starts at 0.That is, the first element of an array is at index 0.
            //If the size of an array is 5, the index of the last element will be at 4(5 - 1).

            int[ , ] ints = { { 1, 2, 3 } ,{ 4, 5, 6 } };
            for(int i=0; i<2; i++)
            {
               for(int j=0; j<3; j++)
               {
                   Console.Write(ints[i, j]+"  ");
               }
               Console.WriteLine("\n");
            }


            //------------------------------------------------------------------------------------------------------------------------

            // Foreach

            string[] names = { "omer", "ali", "yusuf", "hasan" };

            foreach(string name in names) 
            {
               Console.Write(name+(char)(32));
            }

            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {
               if (g == 'm')
                   male++;
               else if (g == 'f')
                   female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);


            // Note that we used System.Linq above.
            int[] numbers = { 51, -1, 2, 14, 18, 40, 178 };
            //// get the minimum element
            Console.WriteLine("Smallest  Element: " + numbers.Min());

            // Max() returns the largest number in array
            Console.WriteLine("Largest Element: " + numbers.Max());

            // compute Count
            Console.WriteLine("Count : " + numbers.Count());

            // compute Sum
            Console.WriteLine("Sum : " + numbers.Sum());

            // compute the average
            Console.WriteLine("Average: " + numbers.Average());


            //------------------------------------------------------------------------------------------------------------------------

            // Math

            Console.WriteLine("Max of 5, 10 is: {0}", Math.Max(5, 10));
            Console.WriteLine("Min of 5, 10 is: {0}", Math.Min(5, 10));
            Console.WriteLine("Squir Root of 64 is: {0}", Math.Sqrt(64));
            Console.WriteLine("Absolute (positive) value of  -4.7 is: {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 is: {0}", Math.Round(9.99));

            //------------------------------------------------------------------------------------------------------------------------

            // Functions

            PrintMyName();
            //You should use static if you want to call the method without having obejct.

            Console.WriteLine(GetMyName());

            PrintMyName("omer", "Memes");
            PrintMyName("omer", "Ahmed",  "Memems");
            ////Named Arguments
            PrintMyName(Name: "omer", MiddleName: "Ahmed");


            //------------------------------------------------------------------------------------------------------------------------

            // When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.
            // When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).

            // The try statement allows you to define a block of code to be tested for errors while it is being executed.
            // The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.
            // The try and catch keywords come in pairs:


            try
            {
               int[] myNumbers = { 1, 2, 3 };
               Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
            }

            try
            {
               int[] numbers = { 1, 2, 3, 5 };
               Console.WriteLine(numbers[-1]);
            }catch (Exception e) 
            {
               Console.WriteLine(e.Message);
            }

            //------------------------------------------------------------------------------------------------------------------------
            Random random = new Random();
            for(int i=0; i<54; i++)
            {
               Console.WriteLine(random.Next(1,55));
            }

            //------------------------------------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------------------------------------

            //------------------------------------------------------------------------------------------------------------------------
            //                                                 Ömer MEMES
            //------------------------------------------------------------------------------------------------------------------------



            Console.ReadKey(); // system("pause > 0") in C++

        }
    }
}
 