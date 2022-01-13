namespace Builder
{
    public class HightClassVacationBuilder : VacationBuilder
    {
        public override void BuildLocation()
        {
            vacation.SetLocaion("Tell Aviv");
        }

        public override void BuildSHotelTitle()
        {
            vacation.SetHotelTitle("Lagoardia");
        }

        public override void BuildFlightCompanyTitle()
        {
            vacation.SetCustomerName("Elale");
        }

        public override void BuildCustomerName()
        {
            vacation.SetFlightCompanyTitle("Naim");
        }
    }
}