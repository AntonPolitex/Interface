using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IRobot
    {
        public string GetInfo() 
        {
            throw new NotImplementedException();
        }
        public List<string> GetComponents() 
        {
            throw new NotImplementedException();
        }
        public string GetRobotType() 
        {
            return "I am a simple robot.";
        }
    }
}
