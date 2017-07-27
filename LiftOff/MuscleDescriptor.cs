using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftOff
{
    public class MuscleDescriptor
    {
        protected MuscleID affectedMuscle;
        protected float descriptionValue;

        public MuscleDescriptor(MuscleID _muscle, float val)
        {
            AffectedMuscle = _muscle;
            Value = val;
        }


        public MuscleID AffectedMuscle
        {
            get { return affectedMuscle; }
            private set { affectedMuscle = value; }
        }
        public float Value
        {
            get { return descriptionValue; }
            private set { descriptionValue = Utility.Clamp(value, 0f, 1f); }
        }
    }
}
