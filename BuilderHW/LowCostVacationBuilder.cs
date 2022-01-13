namespace Builder
{
    public class LowCostVacationBuilder : VacationBuilder
    {
        public override void BuildLocation()
        {
            vacation.SetLocaion("Elate");
        }

        public override void BuildSHotelTitle()
        {
            vacation.SetHotelTitle("Royal Garden");
        }

        public override void BuildFlightCompanyTitle()
        {
            vacation.SetCustomerName("Pegasos");
        }

        public override void BuildCustomerName()
        {
            vacation.SetFlightCompanyTitle("Rami");
        }
    }
}