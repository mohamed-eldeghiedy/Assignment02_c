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


            Console.WriteLine("Enter Number : ");
            int num = int.Parse(Console.ReadLine()!);
            if ( num < 0 )
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
            #endregion
        }
    }
}
