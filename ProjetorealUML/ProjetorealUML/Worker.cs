using ProjetorealUML.Enums;
using System.Reflection.Metadata.Ecma335;

namespace ProjetorealUML
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departiments Departiments { get; set; }
        public List<HourContracts> Contracts { get; set; } = new List<HourContracts>();
                 
        public Worker () 
        {
        
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departiments departiments)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departiments = departiments;
        }

        public void AddContract (HourContracts contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContrat (HourContracts contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int mouth)
        {
            double sum = BaseSalary;
            foreach (HourContracts contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        


    }
}
