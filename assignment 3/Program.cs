namespace assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1.Write a program that allows the user to enter a number then print it
            int number;
            Console.WriteLine(" please enter number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
            #endregion


            #region Q2
            //2.Write C# program that converts a string to an integer, but the string contains non-numeric characters.And mention what will happen 
            string a = "abcd1234";
            int res = Convert.ToInt32(x);    // runtime error will appear because the format of string 
            #endregion



            #region Q3
            //3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            double num1 = 1.5;
            double num2 = 0.5;
            double sum = num1 + num2;
            Console.WriteLine("Sum =" + " " + sum); //2
            #endregion

            #region Q4
            //4.Write C# program that Extract a substring from a given string.
            string s = "hello world";
            String SubString = s.Substring(5);
            Console.WriteLine(SubString);
            #endregion

            #region Q5
            //5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 2;
            int y = 3;
            x = y; //x=3    //y=3
            x = 4;
            Console.WriteLine(x);
            Console.WriteLine(y);
            #endregion

            #region Q6
            // 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = arr1;
            arr2[1] = 5;
            Console.WriteLine($" Arr01 ={arr1[1]}  Arr02 ={arr2[1]}");
            #endregion

            #region Q7
            // 7.Write C# program that take two string variables and print them as one variable 
            string c = "hello";
            string d = "world";
            Console.WriteLine(c + " " + d);
            #endregion

            #region Q8
            // 8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is
            //Interest = (principal * rate * time) / 100.
            double principal = 1000.0;
            double rate = 3.0;
            double time = 8.0;

            double interest = (principal * rate * time) / 100;
            Console.WriteLine("interest = " + interest);
            #endregion

            #region Q9
            //9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is
            //BMI = (Weight) / (Height * Height)
            double weight = 60.0;
            double height = 1.55;
            double BMI = (weight) / (height * height);

            Console.WriteLine(" Your BMI is = " + BMI);
            #endregion

            #region Q10
            //10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            //Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold",
            //above 30 degrees is "Just Hot", and anything else is "Just Good".

            double temp = 9.5;
            string message = temp < 10 ? "too cold" : temp > 30 ? " too hot" : "just good";
            Console.WriteLine(message);
            #endregion

            #region Q11
            //11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            // Ex:
            // Today’s date : 20 , 11 , 2001
            // Today's date : 20 / 11 / 2001
            // Today's date : 20 – 11 – 2001

            DateTime dateTime = DateTime.Now;

            string formate1 = $"{dateTime.Day},{dateTime.Month},{dateTime.Year}";
            string formate2 = $"{dateTime.Day} / {dateTime.Month} / {dateTime.Year}";
            string formate3 = $"{dateTime.Day} - {dateTime.Month} - {dateTime.Year}";

            Console.WriteLine(formate1);
            Console.WriteLine(formate2);
            Console.WriteLine(formate3);
            #endregion

            #region Q12
            //12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output: Yes
            // Example(2)
            //Input: 9
            //Output: No
            Console.Write("Enter Your Number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
            {

                Console.WriteLine("Yes");

            }
            else
                Console.WriteLine("No");
            #endregion


            #region Q13
            //13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            // Example(1)
            //Input: -5
            // Output: negative
            Console.Write("Enter your number:");
            int x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                Console.WriteLine("negative");

            }
            else if (x > 0)
            {

                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("Zero");
            }
            #endregion

            #region Q14
            //        14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            //      Example(1)
            //      Input: 7,8,5
            //      Output:
            //        max element = 8
            //         min element = 5
            ////Example(2)
            ////Input: 3 6 9
            //Outputs:
            //Max element = 9
            //Min element = 3

            Console.WriteLine("Enter Three Numbers:");
            int num1;
            num1 = int.Parse(Console.ReadLine());

            int num2;
            num2 = int.Parse(Console.ReadLine());

            int num3;
            num3 = int.Parse(Console.ReadLine());

            int max = num1;
            int min = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            if (num2 < min)
            {
                min = num2;
            }

            if (num3 < min)
            {
                min = num3;
            }

            Console.WriteLine($"max ={max}");
            Console.WriteLine($"min ={min}");
            #endregion

            #region Q15
            // 15-Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter Your Number:");
            int i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("even");
            }

            else
            {

                Console.WriteLine("odd");
            }
            #endregion

            #region Q16
            //16- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            // Example(1)
            //Input: O
            //Output: vowel
            // Example(2)
            // Input: b
            //Output: Constnant
            char c;
            bool flag;
            do
            {
                Console.WriteLine("Enter Your Char :");
                flag = char.TryParse(Console.ReadLine(), out c);

            } while (!flag);
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Constant");
                    break;
            }
            #endregion

            #region Q17
            {
                //17- Write a program to input the month number and print the number of days in that month.
                //Example
                // Input: Month Number: 1
                //Output: Days in Month: 31
                Console.WriteLine("Enter Month Number {1-12}");
                int month;
                month = int.Parse(Console.ReadLine());
                int days;
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Days in Month: 31");
                        break;

                    case 2:
                        Console.WriteLine("Days in Month:28");
                        break;

                    default:
                        Console.WriteLine("Days in Month:30");

                        break;

                }
            }
            #endregion


            #region Q18
            //18- Write a program to create a Simple Calculator.
            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second Number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"num1+num2={num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"num1-num2={num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"num1*num2={num1 * num2}");
                    break;


                case '/':
                    Console.WriteLine($"num1/num2={num1 / num2}");
                    break;

                default:
                    Console.WriteLine("invalid operator");
                    break;

            }
            #endregion


            #region Q19
            //19.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Example
            //Input: 5
            //Output: 1, 2, 3, 4, 5

            Console.WriteLine("Enter Your Number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + ",");
            }

            #endregion


            #region Q20
            //20- Write a program that allows the user to insert an integer then 
            // print a multiplication table up to 12.
            //Example
            //Input: 5
            //Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            Console.WriteLine("Enter Your Number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num * i}");
            }

            #endregion

            #region Q21
            //21- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Example:
            //Input: 15
            //Output: 2 4 6 8 10 12 14

            Console.WriteLine("Enter Your Number");
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i < num; i++)
            {
                if (i % 2 == 0)

                    Console.WriteLine(i + " ");
            }
            #endregion



            #region Q22
            // Write a program that takes two integers then prints the power.

            // 4 ^ 3 = 64
            // 4 * 4 * 4
            Console.WriteLine("Enter your Base");
            int Base = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Power");
            int Power = int.Parse(Console.ReadLine());

            int result = 1;

            if (Power > 0)
            {
                for (int i = 0; i < Power; i++)
                    result *= Base;
                Console.WriteLine($"{Base} ^ {Power} = {result}");

            }

            else if (Power > 0)
            {
                for (int i = Power; i < 0; i++)
                    result *= Base;
                Console.WriteLine($"{Base} ^ {Power} = {1 / result}");

            }
            else
                Console.WriteLine($"{Base} ^ {Power} = 1");
            #endregion

            #region Q23
            //Write a program to allow the user to enter int and print the REVERSED of it
            Console.WriteLine("Enter a Number To Reverse It");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            while (num > 0)
            {
                int reminder = num % 10;
                result = (result * 10) + reminder;
                num = num / 10;
            }
            Console.WriteLine(result);
            #endregion

            #region Q24
            //24- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Test Data :
            //Input starting number of range: 1
            //Input ending number of range: 50

            //Expected Output :
            //The prime number between 1 and 50 are:
            //2 3 5 7 11 13 17 19 23 29 31 37 41 43 47


            int Start;
            bool flage;


            do
            {

                Console.WriteLine("Enter Number");
                flage = int.TryParse(Console.ReadLine(), out Start);


            } while (!flage);

            int End;
            bool flage02;


            do
            {

                Console.WriteLine("Enter Number");
                flage02 = int.TryParse(Console.ReadLine(), out End);


            } while (!flage02);



            for (int i = Start; i <= End; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }


                }
                if (count == 0 & i != 1)
                    Console.WriteLine(i);

            }
            #endregion

            #region Q25
            //Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Test Data :
            //Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.

            Console.WriteLine("Enter Your Number To Conver It");

            int num = int.Parse(Console.ReadLine());
            int num2 = num;
            string binary = "";
            while (num > 0)
            {
                binary = (num % 2) + binary;
                num /= 2;
            }
            Console.WriteLine($"The Binary number of {num2} is {binary}");
            #endregion

            #region Q26
            //Write a program in C# Sharp to find the sum of all elements of the array.

            int[] array = { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }
            Console.WriteLine("The sum of all elements in the array is:" + sum);
            #endregion


        }
    }
}
