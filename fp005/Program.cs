namespace proxy05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Nro 1:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nro 2:");
            b = int.Parse(Console.ReadLine());

            intercambiar(ref a, ref b);

            Console.WriteLine($"nro1.{a}");
            Console.WriteLine($"nro1.{b}");
            Console.ReadKey();
        }

        private static void intercambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }
}