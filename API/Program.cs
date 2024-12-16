namespace API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //BookResponse testResponse = await APIMethods.GetBooksAsync(quantity:18, locale: "sr_Cyrl_RS", seed:1);

            //testResponse.Results.ForEach(x => Console.WriteLine(x.Author));


            FlightResponse testResponse = await APIMethods.GetFlights();
            List<Flight> flights = testResponse.FlightList;


            //await Task.Delay(5000);
            foreach (Flight flight in flights)
            {
                Console.WriteLine(flight.Route.Destinations.Count);
            }
        }
    }
}
