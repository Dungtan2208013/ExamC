using Animal;

namespace Measurement
{
     class Program
     {
        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "lion");
            Tiger tiger = new Tiger(100, "tiger");

            lion.Show();
            tiger.Show();
        }
     }

}
