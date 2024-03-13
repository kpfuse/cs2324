namespace cs_lab05_exceptions
{
    internal class Program05100
    {
        static void Main051(string[] args)
        {
            double x = 0, y;
            try
            {
                x = double.Parse(Console.ReadLine() ?? "0");
                y = double.Parse(Console.ReadLine() ?? "1");
               
                double z = div3(x, y);

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
            catch (ArgumentException ex) 
            {
                Console.WriteLine("Неверные данные для деления ");
                Console.WriteLine("Подробности: ");
                Console.WriteLine("Когда случилось? " + ex.Data["date"]);
                Console.WriteLine("x = " + ex.Data["x"]);
                Console.WriteLine("y = " + ex.Data["y"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Что-то пошло не так...");
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("-----------\nДальше происходите еще много-много интересного....");
        }
        // выброс исключений из методов
        static double div(double x, double y)
        {
            if (0 == y)
                throw new DivideByZeroException(); // любой подходящий тип исключений
            return x / y;
        }
          static double div2(double x, double y)
        {
            if (0 == y)
                throw new ArgumentException(); // 
            return x / y;
        }
       
        static double div3(double x, double y)
        {
            ArgumentException ex = new ArgumentException();
            // подробности о состоянии в момент исключения
            ex.Data.Add("date", DateTime.Now); 
            ex.Data.Add("x", x);
            ex.Data.Add("y", y);
            if (0 == y)
                throw ex;

            return x / y;
        }

    }
}
