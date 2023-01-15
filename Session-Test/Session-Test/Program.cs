namespace Session_05
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // 1. Reverse a given string

            ReverseStr rev = new ReverseStr();
            Console.WriteLine("1. My name in reverse is : {0}\r\n", rev.PrintRev());



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


            
            // 3. All prime numbers from 1 to chosen number

            Console.WriteLine("3. Please enter the range for the prime number search: ");
            string input = Console.ReadLine();
            int n = Convert.ToInt32(input);

            
            PrimeNum primenum = new PrimeNum();
            Console.WriteLine("The prime numbers from 1 to {0} are: ", n);
            primenum.NumPrime(n);
            Console.WriteLine("\r\n");



            // 4. Multiply each element of one array to the elements of another and display the results in a third array.

            CartesProd cartprod = new CartesProd();
            
            foreach (int len in cartprod.CartProd())
            {
                Console.Write(len.ToString() + ", ");
            }
            Console.WriteLine("\r\n");



            // 5. Sort given Array of integers in ascending order

            AscendSort ascendsort = new AscendSort();

            foreach (int num in ascendsort.BubbleSort())
            {
                Console.Write(num.ToString() + ", ");
            }




            Console.ReadLine();
            
        }
    }
}