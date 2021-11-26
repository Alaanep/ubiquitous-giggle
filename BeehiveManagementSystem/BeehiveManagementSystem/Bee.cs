using System;
namespace BeehiveManagementSystem
{
    public class Bee
    {
        public string Job{ get; private set; }
        public Bee(string job)
        {
            Job = job;
        }

        public virtual float CostPerShift { get; }

        public virtual void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }

        protected virtual void DoJob() { }
    }
}
