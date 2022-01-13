namespace Builder
{
    public class Vacation
    {
        private string location;
        private string hotelTitle;
        private string flightCompanyTitle;
        private string customerName;

        public void SetLocaion(string location)
        {
            this.location = location;
        }

        public void SetHotelTitle(string hotelTitle)
        {
            this.hotelTitle = hotelTitle;
        }

        public void SetFlightCompanyTitle(string flightCompanyTitle)
        {
            this.flightCompanyTitle = flightCompanyTitle;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
    }
}