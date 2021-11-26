using System;
namespace BeehiveManagementSystem
{
    public abstract class Bee
    {
        public string Job{ get; private set; }
        public Bee(string job)
        {
            Job = job;
        }

        public abstract float CostPerShift { get; }

        public virtual void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected abstract void DoJob();
    }
}
