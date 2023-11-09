using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BorderControl
{
    public class City
    {
        //--------------- Fields -----------------
        private List<Citizen> citizens;
        private List<Robot> robots;
        private List<string> detainedIds;

        //------------- Constructors -------------
        public City()
        {
            citizens= new List<Citizen>();
            robots= new List<Robot>();
            detainedIds= new List<string>();
        }
        //-------------- Properties --------------
        public IReadOnlyCollection<Citizen> Citizens => citizens;
        public IReadOnlyCollection<Robot> Robots => robots;
        public IReadOnlyCollection<string> DetainedIds => detainedIds;
        //------------ Public Methods ------------
        public void AddCitizen(Citizen citizen) 
        {
            citizens.Add(citizen);
            detainedIds.Add(citizen.Id);
        }
        public void AddRobot(Robot robot)
        {
            robots.Add(robot);
            detainedIds.Add(robot.Id);
        }
        public void DetainRebels(string filter)
        {
            Predicate<string> predicate = id => id.EndsWith(filter);
            detainedIds.RemoveAll(x=> !predicate(x));
            robots.RemoveAll(r => predicate(r.Id));
        }
        public override string ToString()
        {
            return $"{String.Join(Environment.NewLine, detainedIds)}";
        }
    }
}
