using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Quadcopter: IFlyingRobot ,IChargeable
    {
        private List<string> _components;
        public Quadcopter() 
        {
            _components = new List<string>() { "rotor1", "rotor2", "rotor3", "rotor4" };
        }
        public List<string> GetComponents() 
        {
            return _components;
        }
        public void Charge() 
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged");
        }
        public string GetRobotType()
        {
            return "I am a Quadcopter.";
        }
        public string GetInfo() 
        {
            return $"I have {_components.Count} components";
        }
         string IRobot.GetInfo()
        {
            return $"I am a Quadcopter";
        }
        string IChargeable.GetInfo()
        {
            return "I can charge ";
        }

    }
}
