namespace cs_lab05_exceptions
{
    internal class Program031_checked
    {
        static void Main031(string[] args)
        {
            int x = 0, y;
            try
            {
               //checked
               // {
                    x = int.Parse(Console.ReadLine() ?? "0");
                    y = int.Parse(Console.ReadLine() ?? "1");

                    int z = x + y;

                    Console.WriteLine($"x + y = {x} + {y} = {z}");
            //   }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение, эти данные не умещаются в переменную");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат данных");
            }
            catch (Exception ex)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Что-то пошло не так...");
            }

            Console.WriteLine("-----------\nДальше происходите еще много-много интересного....");
        }

        static int div(int x, int y) => x / y;


    }
}
