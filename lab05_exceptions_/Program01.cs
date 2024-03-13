namespace cs_lab05_exceptions
{
    internal class Program01
    {
        static void Main01(string[] args)
        {
            try
            {
                int x = int.Parse(Console.ReadLine() ?? "0");
                int y = int.Parse(Console.ReadLine() ?? "1");

                int z = div(x, y);

                Console.WriteLine("x / y = {0} / {1} = {2}", x, y, z);
            }
            catch 
            {
                Console.WriteLine("Что-то пошло не так...");
            }
            //finally
            //{
            //    Console.WriteLine("Это надо сделать обязательно, в любом случае"); // помирать собирайся, а рожь сей
            //}

            Console.WriteLine("Дальше происходите еще много-много интересного....");
        }

        static int div(int x, int y) => x / y;

        static void f() => f();
    }
}
