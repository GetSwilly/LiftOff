using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public class Level
    {
        private static readonly int MINIMUM_LEVEL = 0;
        private static readonly int MAXIMUM_LEVEL = 10;

        private int m_CurrentLevel;

        public Level(int _level)
        {
            CurrentLevel = _level;
        }


        public int CurrentLevel
        {
            get { return m_CurrentLevel; }
            set
            {
                m_CurrentLevel = value;

                if(m_CurrentLevel < MINIMUM_LEVEL)
                {
                    m_CurrentLevel = MINIMUM_LEVEL;
                }
                else if(m_CurrentLevel > MAXIMUM_LEVEL)
                {
                    m_CurrentLevel = MAXIMUM_LEVEL;
                }
            }
        }
    }
}
