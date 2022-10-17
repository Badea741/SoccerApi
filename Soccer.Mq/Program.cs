namespace Soccer.MQ;
public class Program
{
    public static void Main(string[] args)
    {
        int x = 10;
        void Test()
        {
            x = 20;
        }
        Test();
        System.Console.WriteLine(x);
    }

}