namespace GeometryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder cylinder = new Cylinder();
            Console.WriteLine("Cylinder Characteristics:");
            Console.Write(cylinder);
            cylinder.Process();
            cylinder.Result();
        }
    }
}
