using System;

namespace P01_Events
{
    class Program
    {
        public static void Main(string[] args)
        {
            Ball ball = new Ball();
            Player P11 = new Player() {Name = "Messi", Team = "PSG" };
            Player P12 = new Player() {Name = "Nymar", Team = "PSG" };
            Player P21 = new Player() {Name = "Salah", Team = "LiverPool" };
            Player P22 = new Player() {Name = "Sane", Team = "LiverPool" };
            Refree refree = new Refree() { Name = "Gresha"};
            
            

            
            Console.WriteLine("Before Subscribton");
            //ball.BallLocation = new Location { X = 10, Y = 20, Z = 30 };
            Console.WriteLine(ball);





            ball.BallLocationChanged += P11.Run;
            ball.BallLocationChanged += P12.Run;
            ball.BallLocationChanged += P21.Run;
            ball.BallLocationChanged += P22.Run;
            ball.BallLocationChanged += refree.Look;
            ball.BallLocationChanged += (Location l) => Console.WriteLine($"Hello to {l}");




            Console.WriteLine("After Subscribton");
            ball.BallLocation = new Location { X = 20, Y = 20, Z = 40 };
            Console.WriteLine(ball);





            ball.BallLocationChanged -= P22.Run;
            ball.BallLocation = new Location { X = 90, Y = 10, Z = 10 };
            Console.WriteLine(ball);


        }
    }
}