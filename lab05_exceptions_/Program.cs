namespace cs_lab05_exceptions
{
    internal class Program
    {
        static void Main00(string[] args)
        {
            int x = int.Parse(Console.ReadLine() ?? "0");
            int y = int.Parse(Console.ReadLine() ?? "1");

            int z = div(x, y);

            Console.WriteLine("x / y = {0} / {1} = {2}", x, y, z);

            Console.WriteLine("Дальше происходите еще много-много интересного....");
        }

        static int div(int x, int y) => x / y;
    }
}
