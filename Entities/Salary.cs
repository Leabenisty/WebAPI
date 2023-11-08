namespace Web_API.Entities
{
    public class Salary
    {
        double basesalary;
        double bouns;
        double dailysalary;
        public double Basesalary { get => basesalary; set => basesalary = value; }
        public double Bouns { get => bouns; set => bouns = value; }
        public double Dailysalary { get => dailysalary; set => dailysalary = value; }

        public Salary(double basesalary,double bouns)
        {
            this.basesalary = basesalary;
            this.bouns = bouns;
        }
        public Salary(double dailysalary)
        {
            this.dailysalary = dailysalary;
            this.bouns=50;
        }
    }
}
