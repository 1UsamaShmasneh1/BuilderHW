using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Example.");
            VacationBuilder lowCostVacationBuilder = new LowCostVacationBuilder();
            lowCostVacationBuilder.ConstructVacation();
            Vacation vacation = lowCostVacationBuilder.GetVacation();
        }
    }
}