namespace cs_lab05_exceptions
{
    internal class Program05000
    {
        static void Main050(string[] args)
        {
            double x = 0, y;
            try
            {
                x = double.Parse(Console.ReadLine() ?? "0");
                y = double.Parse(Console.ReadLine() ?? "1");
                //if (0 == y)
                //    throw new DivideByZeroException();
                double z = div(x, y);

                Console.WriteLine("x / y = {0} / {1} = {2}", x, y, z);

            }
            catch (DivideByZeroException ex)  
            {
                Console.WriteLine("Делить на ноль нельзя");
            }           
            catch (FormatException ex) 
            {
                Console.WriteLine("Неверный формат данных");
            }
            catch (Exception ex)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Что-то пошло не так...");
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("-----------\nДальше происходите еще много-много интересного....");
        }

        static double div(double x, double y) => x / y;


    }
}
