using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engineers
{
    public class Engineers
    {
        public List<Engineer> AllEngineers = new List<Engineer>();

        //public Engineer LizRyder = new Engineer("Liz Ryder", "http://inara.cz/galaxy-engineer/5");
        //public Engineer BrooTarquin = new Engineer("Broo Tarquin", "http://inara.cz/galaxy-engineer/15");
        //public Engineer ColonelBrisDekker = new Engineer("Colonel Bris Dekker", "http://inara.cz/galaxy-engineer/14");
        //public Engineer DidiVaterman = new Engineer("Didi Vaterman", "http://inara.cz/galaxy-engineer/11");
        //public Engineer ElviraMartuuk = new Engineer("Elvira Martuuk", "http://inara.cz/galaxy-engineer/2");
        //public Engineer FelicityFarseer = new Engineer("Felicity Farseer", "http://inara.cz/galaxy-engineer/1");
        //public Engineer HeraTani = new Engineer("Hera Tani", "http://inara.cz/galaxy-engineer/12");
        //public Engineer JuriIshmaak = new Engineer("Juri Ishmaak", "http://inara.cz/galaxy-engineer/13");
        //public Engineer LeiCheung = new Engineer("Lei Cheung", "http://inara.cz/galaxy-engineer/10");
        //public Engineer MarcoQwent = new Engineer("Marco Qwent", "http://inara.cz/galaxy-engineer/7");
        //public Engineer ProfessorPalin = new Engineer("Professor Palin", "http://inara.cz/galaxy-engineer/3");
        //public Engineer SeleneJean = new Engineer("Selene Jean", "http://inara.cz/galaxy-engineer/8");
        //public Engineer TheDweller = new Engineer("The Dweller", "http://inara.cz/galaxy-engineer/4");
        //public Engineer TodTheBlasterMcQuinn = new Engineer("Tod \"The Blaster\" McQuinn", "http://inara.cz/galaxy-engineer/6");
        //public Engineer ZacariahNemo = new Engineer("Zacariah Nemo", "http://inara.cz/galaxy-engineer/9");

        public Engineers()
        {
            AllEngineers.Add(new Engineer("Liz Ryder", "http://inara.cz/galaxy-engineer/5"));
            AllEngineers.Add(new Engineer("Broo Tarquin", "http://inara.cz/galaxy-engineer/15"));
            AllEngineers.Add(new Engineer("Colonel Bris Dekker", "http://inara.cz/galaxy-engineer/14"));
            AllEngineers.Add(new Engineer("Didi Vatermann", "http://inara.cz/galaxy-engineer/11"));
            AllEngineers.Add(new Engineer("Elvira Martuuk", "http://inara.cz/galaxy-engineer/2"));
            AllEngineers.Add(new Engineer("Felicity Farseer", "http://inara.cz/galaxy-engineer/1"));
            AllEngineers.Add(new Engineer("Hera Tani", "http://inara.cz/galaxy-engineer/12"));
            AllEngineers.Add(new Engineer("Juri Ishmaak", "http://inara.cz/galaxy-engineer/13"));
            AllEngineers.Add(new Engineer("Lei Cheung", "http://inara.cz/galaxy-engineer/10"));
            AllEngineers.Add(new Engineer("Marco Qwent", "http://inara.cz/galaxy-engineer/7"));
            AllEngineers.Add(new Engineer("Professor Palin", "http://inara.cz/galaxy-engineer/3"));
            AllEngineers.Add(new Engineer("Selene Jean", "http://inara.cz/galaxy-engineer/8"));
            AllEngineers.Add(new Engineer("The Dweller", "http://inara.cz/galaxy-engineer/4"));
            AllEngineers.Add(new Engineer("Tod \"The Blaster\" McQuinn", "http://inara.cz/galaxy-engineer/6"));
            AllEngineers.Add(new Engineer("Zacariah Nemo", "http://inara.cz/galaxy-engineer/9"));
        }

        public Engineer getEngineerByName(string engineerName)
        {
            foreach(Engineer eng in AllEngineers)
            {
                if(eng.Name.Equals(engineerName)) { return eng; }
            }
            return new Engineer("-?-", "");
        }
    }

}
