namespace switchcasemonthofyearqisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthOfYear = 2;
            switch (monthOfYear)
            {
                case 1: case 11: case 12:
                    Console.WriteLine("winter");
                    break;
                case 2: case 3: case 4:
                    Console.WriteLine("spring");
                    break;
                case 5: case 6: case 7:
                    Console.WriteLine("summer");
                    break;
                case 8: case 9: case 10:
                    Console.WriteLine("autumn");
                    break;

                default : Console.WriteLine("wrong");
                    break;

            }
        }
    }
}