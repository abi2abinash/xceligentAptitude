using System;

namespace AxceligentAptitude
{
    internal class Humanoid
    {
        HumanoidSkill HumanoidSkill;

        public Humanoid()
        {
        }

        public Humanoid(HumanoidSkill humanoidSkill)
        {
            this.HumanoidSkill = humanoidSkill;
        }

        internal string ShowSkill()
        {
            if (HumanoidSkill == null)
            {
                return "no skill is defined";
            }
            else
            {
                return HumanoidSkill.ShowSkill();
            }
        }
    }


   public interface HumanoidSkill
    {
         string ShowSkill();
    }
}