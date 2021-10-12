using System.Collections.Generic;
using T2.Entities.Enums;

namespace T2.Entities
{
    class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; } = new Department();

        public List<HourContract> Contracts
        { get; set;
        } = new List<HourContract>();

        public void AddContract(HourContract contract)
        {
            Contracts.Add (contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove (contract);
        }

        public double Income(int year, int month)
        {
            double value = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                int Y = (int)contract.Date.Year;
                int M = (int)contract.Date.Month;

                if (year == Y && month == M)
                {
                    value += contract.TotalValue();
                }
            }

            return value;
        }
    }
}
