namespace Assignment02_c
{
    internal class Program
    {
        static void Main()
        {

            #region p1:Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.


            //Console.WriteLine(" Enter Number : ");
            //int number = int.Parse(Console.ReadLine()!);
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion


            #region p2:Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.


            //Console.WriteLine("Enter Number : ");
            //int num = int.Parse(Console.ReadLine()!);
            //if ( num < 0 )
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}
            #endregion


            #region p3: Write a program that takes 3 integers from the user then prints the max element and the min element.


            //Console.WriteLine(" Enter First Number :");
            //int num1 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine(" Enter Second Number :");
            //int num2 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine(" Enter Third Number :");
            //int num3 = int.Parse(Console.ReadLine()!);


            //int MIN = Math.Min(num1, Math.Min(num2,num3));
            //int Max = Math.Max(num1, Math.Max(num2, num3));

            //Console.WriteLine("Min Number : " + MIN);
            //Console.WriteLine("Max Number : " + Max);
            #endregion


            #region p4:Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter Number : ");
            //int Num = int.Parse(Console.ReadLine()!);

            //if (Num % 2 == 0)
            //{
            //    Console.WriteLine("the number is even");
            //}
            //else {
            //    Console.WriteLine("the number is odd");
            //}

            #endregion


            #region p5:Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).


            //Console.WriteLine(" Enter a character : ");
            //char ch = char.Parse(Console.ReadLine().ToLower());

            //if (ch == 'a' || ch == 'e' || ch == 'o'|| ch == 'u'|| ch == 'i')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else 
            //{
            //    Console.WriteLine("consonant");
            //}
            #endregion


            #region p6:Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine(" Enter Number : ");
            //int input = int.Parse(Console.ReadLine()!);
            //for (int i = 1; i <= input; i++) 
            //{

            //    Console.Write(i + " , ");
            //}
            //Console.WriteLine();


            #endregion


            #region p7:Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine(" Enter Number :");
            //int num_mlt = int.Parse(Console.ReadLine()!);
            //Console.WriteLine();

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i*num_mlt);
            //}
            #endregion


            #region p8:Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter Number : ");
            //int num_even = int.Parse(Console.ReadLine()!);

            //for (int i = 1; i < num_even; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i + " , ");

            //    Console.WriteLine();
            //}
            #endregion


            #region p9:Write a program that takes two integers then prints the power.


            //Console.WriteLine(" Enter Frist Number :");
            //int num_1 = int.Parse(Console.ReadLine()!);
            //Console.WriteLine(" Enter Second Number :");
            //int num_2 = int.Parse(Console.ReadLine()!);

            //double power = Math.Pow(num_1, num_2);

            //Console.WriteLine("Result : "+power);


            #endregion


            #region p10:Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] marks = new int[5];
            //int total = 0;

            //Console.WriteLine("Enter Marks of Five Subjects: ");

            //for (int i = 0; i < 5; i++) 
            //{
            //   Console.Write( "Subject "+(i+1) + " :");
            //    marks[i] = int.Parse(Console.ReadLine()!);

            //    total += marks[i];
            //}

            //double avr = total / 0.5;
            //double perc = (total / 500.0) * 100;


            //Console.WriteLine("Total Marks = "+total);
            //Console.WriteLine("Average Marks = " + (int)avr);
            //Console.WriteLine("Percentage = " + (int)perc);


            #endregion


            #region p11:Write a program to input the month number and print the number of days in that month.


            //Console.WriteLine( " Month Number :");

            //int month_num = int.Parse( Console.ReadLine()!);


            //switch (month_num)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31 days");
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30 days");
            //        break;

            //    case 2:
            //        Console.WriteLine("28 or 29 days");
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        break;
            //}


            #endregion


            #region p12:Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.


            //Console.Write("Enter the size of matrix (n): ");
            //int n = int.Parse(Console.ReadLine()!);

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine(); 
            //}

            #endregion


            #region p13:Write a program in C# Sharp to find the sum of all elements of the array.


            //    Console.Write("Enter the number of elements in the array: ");
            //    int size = int.Parse(Console.ReadLine()!);

            //    int[] arr = new int[size];
            //    int sum = 0;

            //    Console.WriteLine("Enter the elements of the array:");

            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write("Element " + (i + 1) + ": ");
            //        arr[i] = int.Parse(Console.ReadLine()!);
            //        sum += arr[i];
            //    }

            //    Console.WriteLine("Sum of all elements = " + sum);
            //}

            #endregion


            #region p14:Write a program in C# Sharp to count the frequency of each element of an array.


            Console.Write("Enter number of elements in the array: ");
            int size = int.Parse(Console.ReadLine()!);

            int[] arr = new int[size];
            int[] freq = new int[size];
            int st = -1;

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine()!);
            }

            for (int i = 0; i < size; i++)
            {
                int count = 1;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        freq[j] = st; 
                    }
                }

                if (freq[i] != st)
                    freq[i] = count;
            }

            Console.WriteLine("\nFrequency of each element:");
            for (int i = 0; i < size; i++)
            {
                if (freq[i] != st)
                    Console.WriteLine(arr[i] + " occurs " + freq[i] + " time(s)");
            }

            #endregion
        }

    }
    

}