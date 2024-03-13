namespace cs_lab05_exceptions
{
    internal class Program02
    {
        static void Main02(string[] args)
        {
            int x = 0, y;
            try
            {
                x = int.Parse(Console.ReadLine() ?? "0");
                y = int.Parse(Console.ReadLine() ?? "1");

                int z = div(x, y);

                Console.WriteLine("x / y = {0} / {1} = {2}", x, y, z);

                //int[] a = { 100, 200, 300};
                //Console.WriteLine(a[z]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Неверный формат данных");
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то пошло не так...");
            }
            finally
            {
                Console.WriteLine("Это надо сделать обязательно, в любом случае"); // помирать собирайся, а рожь сей
            }

            Console.WriteLine("Дальше происходите еще много-много интересного....");
        }

        static int div(int x, int y) => x / y;


    }
}
