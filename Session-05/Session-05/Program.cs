namespace Session_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // 1. Reverse a given string

            string name = "Dimitris Manolas";
            ReverseStr rev = new ReverseStr();
            Console.WriteLine("1. My name in reverse is : {0}\r\n", rev.PrintRev(name));



            // 2. sum or product from 1 to user input

            Console.WriteLine("2. Input number range for sum or product (1 to n): ");
            string number = Console.ReadLine();
            int r = Convert.ToInt32(number);

            Console.WriteLine("Pick between: 1. Sum or 2. Product: ");
            string selection = Console.ReadLine();
            int s = Convert.ToInt32(selection);

            SumProd prodsum = new SumProd();

            if (s == 1)
            {
                Console.WriteLine("The sum of the the numbers from 1 to {0} is: {1}\r\n", r, prodsum.Summary(r));
            }
            if (s == 2)
            {
                Console.WriteLine("The product of the the numbers from 1 to {0} is: {1}\r\n", r, prodsum.Product(r));
            }
            if (s!=1 && s!=2)
            {
                Console.WriteLine("Sorry, Incorrect Input!\r\n");
            }

            


            
            // 3. All prime numbers from 1 to chosen number

            Console.WriteLine("3. Please enter the range for the prime number search: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            
            PrimeNum primenum = new PrimeNum();
            Console.WriteLine("The prime numbers from 1 to {0} are: ", n);
            primenum.NumPrime(n);
            Console.WriteLine("\r\n");



            // 4. Multiply each element of one array to the elements of another and display the results in a third array.

            int[] arrA = { 2, 4, 9, 12 };
            int[] arrB = { 1, 3, 7, 10 };
            Console.WriteLine("4. The elements of the first two arrays are: ");
            foreach (int len in arrA)
            {
                Console.Write(len.ToString() + ", ");
            }
            Console.WriteLine("");
            foreach (int len in arrB)
            {
                Console.Write(len.ToString() + ", ");
            }

            CartesProd cartprod = new CartesProd();
            Console.WriteLine("\r\nThe array produced is: ");

            foreach (int len in cartprod.CartProd(arrA, arrB))
            {
                Console.Write(len.ToString() + ", ");
            }
            Console.WriteLine("\r\n");



            // 5. Sort given Array of integers in ascending order

            int[] myArr = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Console.WriteLine("5. The initial array is:");
            foreach (int num in myArr)
            {
                Console.Write(num.ToString() + ", ");
            }
            Console.WriteLine("");

            AscendSort ascendsort = new AscendSort();

            Console.WriteLine("The given array sorted in ascending order: ");
            foreach (int num in ascendsort.BubbleSort(myArr))
            {
                Console.Write(num.ToString() + ", ");
            }




            Console.ReadLine();
            
        }
    }
}