using System;
namespace BeehiveManagementSystem
{
    public class Queen: Bee
    {
        private float eggs=0;
        private float unassignedWorkers=3;
        private const float EGGS_PER_SHIFT= 0.45f;
        private const float HONEY_PER_UNASSIGNED_WORKER= 0.5f;

        public string StatusReport { get; private set; }
        public override float CostPerShift { get { return 2.15f; } }

        private IWorker[] workers = new IWorker[0];
        private void AddWorker(IWorker worker)
        {
            if(unassignedWorkers >= 1f)
            {
                unassignedWorkers--;
                Array.Resize(ref workers, workers.Length + 1);
                workers[workers.Length - 1] = worker;
            }
        }

        public Queen() : base("Queen")
        {
            AssignBee("Nectar Collector");
            AssignBee("Egg Care");
            AssignBee("Honey Manufacturer");

        }

        public void AssignBee(string job)
        {
            switch (job)
            {
                case "Egg Care":
                    AddWorker(new EggCare(this));
                    break;
                case "Nectar Collector":
                    AddWorker(new NectarCollector());
                    break;
                case "Honey Manufacturer":
                    AddWorker(new HoneyManufacturer());
                    break;
            }
            UpdateStatusReport();
        }

        public void CareForEggs(float eggsToConvert)
        {
            if (eggs >= eggsToConvert)
            {
                eggs -= eggsToConvert;
                unassignedWorkers += eggsToConvert;
            }
        }

        private void UpdateStatusReport()
        {
            StatusReport = $"Vault report: \n{HoneyVault.StatusReport}\n" +
                 $"\nEgg count: {eggs:0.0}\nUnassigned workers: {unassignedWorkers:0.0}\n" +
                 $"{WorkerStatus("Nectar Collector")}\n{WorkerStatus("Honey Manufacturer")}\n" +
                 $"{WorkerStatus("Egg Care")}\nTOTAL WORKERS: {workers.Length}";
        }

        private string WorkerStatus(string job)
        {
            int count = 0;
            foreach(IWorker worker in workers)
            {
                if (worker.Job == job) count++;
            }
            string s = "s";
            if (count == 1) s = "";
            return $"{count} {job} bee{s}";
        }

        protected override void DoJob()
        {
            eggs += EGGS_PER_SHIFT;
            foreach(IWorker worker in workers)
            {
                worker.WorkTheNextShift();
            }

            HoneyVault.ConsumeHoney(unassignedWorkers * HONEY_PER_UNASSIGNED_WORKER);
            UpdateStatusReport();
        }
    }
}
