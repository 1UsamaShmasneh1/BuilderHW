namespace Builder
{
    public abstract class VacationBuilder
    {
        protected Vacation vacation;

        public VacationBuilder()
        {
            vacation = new Vacation();
        }

        public abstract void BuildLocation();

        public abstract void BuildSHotelTitle();

        public abstract void BuildFlightCompanyTitle();

        public abstract void BuildCustomerName();

        public void ConstructVacation()
        {
            BuildLocation();
            BuildSHotelTitle();
            BuildFlightCompanyTitle();
            BuildCustomerName();
        }

        public Vacation GetVacation()
        {
            return vacation;
        }
    }
}