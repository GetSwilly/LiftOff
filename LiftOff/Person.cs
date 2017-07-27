using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public class Person
    {
        private string m_Name;
        private List<Muscle> trackedMuscles;
        private List<Activity> trackedActivities;


        public Person(string _name, List<Muscle> _muscles, List<Activity> _activities)
        {
            Name = _name;
            TrackedMuscles = _muscles;
            TrackedActivities = _activities;
        }


        public bool IsTracking(MuscleID id)
        {
            return TrackedMuscles.Any(m => m.ID == id);
        }
        public bool IsTracking(ActivityID id)
        {
            return TrackedActivities.Any(a => a.ID == id);
        }


        #region Accessors

        public string Name
        {
            get { return m_Name; }
            private set { m_Name = value; }
        }
        public List<Muscle> TrackedMuscles
        {
            get { return trackedMuscles; }
            private set
            {
                if(value == null)
                {
                    trackedMuscles.Clear();
                    return;
                }

                trackedMuscles = value;
            }
        }
        public List<Activity> TrackedActivities
        {
            get { return trackedActivities; }
            private set
            {
                if (value == null)
                {
                    trackedActivities.Clear();
                    return;
                }

                trackedActivities = value;
            }
        }

        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Name: ");
            sb.Append(Name);

            sb.Append(". Muscles: ");
            for(int i = 0; i < TrackedMuscles.Count; i++)
            {
                sb.Append(TrackedMuscles[i]);

                if (i < TrackedMuscles.Count - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append(". Activities: ");
            for (int i = 0; i < TrackedActivities.Count; i++)
            {
                    sb.Append(TrackedActivities[i]);

                if (i < TrackedActivities.Count - 1)
                {
                    sb.Append(", ");
                }
            }
            sb.Append(".");

            return sb.ToString();
        }
    }
}
