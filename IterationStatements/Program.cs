namespace IterationStatements
{
    public class Program
    {

        static void Main(string[] args)
        {
            PrintRange(10, -2);

            Threes();
        }
        public static bool IsEqual(int a , int b)
        {
            if ( a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
         }
            
        public static void Threes()
        {
           for ( int k = 3; k<= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

            public static void PrintRange(int ceiling, int floor )
        {
            for( int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }

    }
}
