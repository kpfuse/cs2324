namespace cs_lab05_exceptions
{
    internal class Program04
    {
        static void Main04(string[] args)
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
            catch (DivideByZeroException ex)  
            {
                Console.WriteLine("Делить на ноль нельзя");
                Console.WriteLine(ex.TargetSite);
            }           
            catch (FormatException ex) 
            {
                Console.WriteLine("Неверный формат данных");
            }
            catch (Exception ex)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Что-то пошло не так...");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.TargetSite);
                //    Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("-----------\nДальше происходите еще много-много интересного....");
        }

        static int div(int x, int y) => x / y;


    }
}
