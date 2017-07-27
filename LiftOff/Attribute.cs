using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public abstract class Attribute
    {
        private Level m_Level;
        private string m_Name;
        private string m_Description;


        public Attribute(string attrName, Level attrLevel, string attrDescription)
        {
            Name = attrName;
            Description = attrDescription;
            Level = attrLevel;
        }

        public string Name
        {
            get { return m_Name; }
            private set { m_Name = value; }
        }
        public string Description
        {
            get { return m_Description; }
            private set { m_Description = value; }
        }
        public Level Level
        {
            get { return m_Level; }
            private set { m_Level = value; }
        }
    }
}
