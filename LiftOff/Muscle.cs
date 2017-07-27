using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public class Muscle : Attribute
    {
        private MuscleID m_ID;

        public Muscle(string attrName, Level attrLevel, string attrDescription, MuscleID musclID) : base(attrName, attrLevel, attrDescription)
        {
            ID = musclID;
        }



        #region Accessors

        public MuscleID ID
        {
            get { return m_ID; }
            private set { m_ID = value; }
        }

        #endregion



        public static int? Compare(Muscle a, Muscle b)
        {
            if (a == null || b == null)
                return null;


            if (!a.ID.Equals(b.ID))
                return null;

            return a.Level.CurrentLevel - b.Level.CurrentLevel;
        }
    }
}
