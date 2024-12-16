namespace API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Response testResponse = await APIMethods.GetBooksAsync();

            Console.WriteLine(testResponse.Results.Count);
        }
    }
}
