using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public class Activity : Attribute
    {
        private ActivityID m_ID;
        private List<MuscleDescriptor> m_MuscleDescriptors;

        public Activity(string attrName, Level attrLevel, string attrDescription, ActivityID actvtyID, List<MuscleDescriptor> actvtyDescriptors) : base(attrName, attrLevel, attrDescription)
        {
            ID = actvtyID;
            MuscleDescriptors = actvtyDescriptors;
        }



        #region Accessors

        public ActivityID ID
        {
            get { return m_ID; }
            private set { m_ID = value; }
        }
        public List<MuscleDescriptor> MuscleDescriptors
        {
            get { return m_MuscleDescriptors; }
            private set { m_MuscleDescriptors = value; }
        }

        #endregion


        public static int? Compare(Activity a, Activity b)
        {
            if (a == null || b == null)
                return null;


            if (!a.ID.Equals(b.ID))
                return null;

            return a.Level.CurrentLevel - b.Level.CurrentLevel;
        }
    }
}
