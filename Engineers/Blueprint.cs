using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineers
{
    public class Blueprint
    {
        public string Module = "";
        public int Grade = 1;
        public string Name = "";
        public int[] RequiredComponentsCount;
        public Component[] RequiredComponents;
        public Engineer[] OfferedBy;

        public Blueprint()
        {
            Module = "";
            Grade = 0;
            Name = "";
            RequiredComponentsCount = new int[] { };
            RequiredComponents = new Component[] { };
            OfferedBy = new Engineer[] { };
        }
        public Blueprint(string initModule, int initGrade, string initName, int[] initRequiredComponentsCount, Component[] initComponents, Engineer[] initEngineer)
        {
            Module = initModule;
            Grade = initGrade;
            Name = initName;
            RequiredComponentsCount = initRequiredComponentsCount;
            RequiredComponents = initComponents;
            OfferedBy = initEngineer;

            if (RequiredComponents.Count() != RequiredComponentsCount.Count())
            {
                throw new Exception("Invalid Blueprint Exception: mismatch in the size of the components[] and componentscount[] passed for object creation.");
            }
        }

        public string componentsToString()
        {
            string modComponents = "";
            for (int i = 0; i < RequiredComponents.Count(); i++)
            {
                modComponents = modComponents + "\t" + RequiredComponentsCount[i].ToString() + "x " + RequiredComponents[i].Name + "\r";
            }
            return modComponents;
        }

        public string engineersToString()
        {
            string engineers = "";
            foreach (Engineer eng in OfferedBy)
            {
                engineers = engineers + eng.Name + "\r";
            }
            return engineers;
        }

        public override string ToString()
        {
            string engineers = "";
            string modComponents = "";

            foreach(Engineer eng in OfferedBy)
            {
                engineers = engineers + " " + eng.Name;
            }
            for (int i = 0; i < RequiredComponents.Count(); i++)
            {
                modComponents = modComponents + "\t" + RequiredComponentsCount[i].ToString() + "x " + RequiredComponents[i].Name + "\r";
            }
            
            return /*"Name: " +*/ Name + " \rModule:" + Module + " \rGrade: " + Grade.ToString() + " \rComponents:\r" + modComponents.Trim() + " \rEngineers:" + engineers.Trim();
        }
    }
}
