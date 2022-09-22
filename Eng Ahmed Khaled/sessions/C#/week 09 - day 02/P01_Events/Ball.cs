using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Events
{
    internal class Ball
    {
        private Location ballLocation;

        public  int Id { get; set; }

        public Location BallLocation
        {
            get => ballLocation;
            set 
            { 
                if(value != ballLocation)
                {
                    ballLocation = value;
                    BallLocationChanged?.Invoke(value);
                }
                    
            }
        }

        public override string ToString() => $"Ball: {Id}, in {ballLocation}";

        public event Action<Location> BallLocationChanged;

    }
}
