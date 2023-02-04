public class Tel
{
    public int day;
    public double time;
    public double money;
    public double SumMoney()
    {
        double totalPrice = time * money;
        if (day == 6 || day == 7)
            return totalPrice - totalPrice * 0.1;
        else return totalPrice;
    }
}
public class Ploshd
{
    public void Repeat()
    {
        int square;
        for (int i = 1; i <= 10; i++)
        {
            square = Convert.ToInt32(Math.Pow(i, 2));
            Console.Write(i + " ");
            StopPloshd ss = new StopPloshd();
            ss.Stop(square);
        }
    }
}

public class StopPloshd
{
    public void Stop(int number)
    {
        if (number > 25)
            Console.WriteLine("Квадрат числа больше 25!");
    }
}

public class Program
{
    static void Main()
    {
        static void TaskOne()
        {
            try
            {
                Tel tel = new Tel();
                while (tel.day < 1 || tel.day > 7)
                {
                    Console.Write("День недели разговора: ");
                    tel.day = Convert.ToInt32(Console.ReadLine());
                    if (tel.day < 1 || tel.day > 7) Console.WriteLine("День должен быть от 1 до 7");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.Write("Время разговора: ");
                tel.time = Convert.ToDouble(Console.ReadLine());
                Console.Write("Стоимость минуты:");
                tel.money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Стоимость разговора: {tel.SumMoney()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        TaskOne();

        static void TaskFree()
        {
            try
            {
                Ploshd cycle = new Ploshd();
                cycle.Repeat();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        TaskFree();

    }

}