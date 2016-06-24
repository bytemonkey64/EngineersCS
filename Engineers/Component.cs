using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineers
{
    public class Component
    {

        public string Name = "";
        public string Type = "";
        public string Occurence = "";
        public string MeansOfAcquiring = "";

        public Component(Component clone)
        {
            Name = clone.Name;
            Type = clone.Type;
            Occurence = clone.Occurence;
            MeansOfAcquiring = clone.MeansOfAcquiring;
        }
        public Component(string ComponentName, string ComponentType, string ComponentOccurence, string ComponentMeansOfAcquiring)
        {
            Name = ComponentName;
            Type = ComponentType;
            Occurence = ComponentOccurence;
            MeansOfAcquiring = ComponentMeansOfAcquiring;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Type:" + Type + " Occurrence:" + Occurence + " MeansOfAcquiring:" + MeansOfAcquiring;
        }


    }

}
