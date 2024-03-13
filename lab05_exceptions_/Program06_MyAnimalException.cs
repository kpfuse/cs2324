namespace cs_lab05_exceptions
{
    internal class Program06
    {
        static void Main(string[] args)
        {
            double x = 0, y;
            try
            {
                x = double.Parse(Console.ReadLine() ?? "0");
                y = double.Parse(Console.ReadLine() ?? "1");
                double z = div(x, y);

                Console.WriteLine("x / y = {0} / {1} = {2}", x, y, z);

                Animal animal = new Animal("Кузя", 40, -7);

            }
            catch (DivideByZeroException ex)  
            {
                Console.WriteLine("Делить на ноль нельзя");
            }           
            catch (FormatException ex) 
            {
                Console.WriteLine("Неверный формат данных");
            }
            catch (MyAnimalException ex) // обработка собственных типов исключений
            {
                Console.WriteLine("Это ошибка в Animal");
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
