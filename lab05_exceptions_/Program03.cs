namespace cs_lab05_exceptions
{
    internal class Program03
    {
        static void Main03(string[] args)
        {
            int x = 0, y;
            try
            {
                x = int.Parse(Console.ReadLine() ?? "0");
                y = int.Parse(Console.ReadLine() ?? "1");

                int z = div(x, y);

                Console.WriteLine("x / y = {0} / {1} = {2}", x, y, z);

                int[] a = { 100, 200, 300 };
                Console.WriteLine(a[4]);
            }
            catch (DivideByZeroException)   when (x > 0)   // фильтры 
            {
                Console.WriteLine("Делить на ноль нельзя, будет +БЕСКОНЕЧНОСТЬ");
            }
            catch (DivideByZeroException)   when (x < 0)
            {
                Console.WriteLine("Делить на ноль нельзя, будет -БЕСКОНЕЧНОСТЬ");
            }
            catch (DivideByZeroException)  
            {
                Console.WriteLine("Делить на ноль нельзя, будет 0/0 неопределенность");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Неверный формат данных");
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то пошло не так...");
            }

            Console.WriteLine("Дальше происходите еще много-много интересного....");
        }

        static int div(int x, int y) => x / y;


    }
}
