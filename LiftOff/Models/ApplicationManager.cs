using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff.Models
{
    public class ApplicationManager
    {
        private Person activeProfile;


        public static ApplicationManager Instance { get; private set; }

        public ApplicationManager()
        {
            Instance = this;

            ActiveProfile = new Person("TEST", new List<Muscle>() { new Muscle("TEST MUSCLE 1", new Level(1), "Musc 1", MuscleID.Abdominals)}, new List<Activity>());
        }



        #region Accessors

        protected Person ActiveProfile
        {
            get { return activeProfile; }
            set { activeProfile = value; }
        }

        public List<Muscle> ActiveMuscles
        {
            get
            {
                List<Muscle> lm = ActiveProfile == null ? new List<Muscle>() : ActiveProfile.TrackedMuscles;

                Console.Out.WriteLine(lm.Count);

                return lm;
            }
        }

        public List<Activity> ActiveActivities
        {
            get { return ActiveProfile == null ? new List<Activity>() : ActiveProfile.TrackedActivities; }
        }

        #endregion

    }
}
