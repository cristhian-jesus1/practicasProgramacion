using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
    
        bool repetir = true;        
        do
        {
            string url = "http://api.open-notify.org/iss-now.json";

            HttpClient client = new HttpClient();

            HttpResponseMessage response = client.GetAsync(url).Result;
            string jsonResponse = response.Content.ReadAsStringAsync().Result;

            var verPosicion = JsonConvert.DeserializeObject<Root>(jsonResponse);

            string latitude = verPosicion.iss_position.latitude;
            string longitude = verPosicion.iss_position.longitude;

            System.Console.WriteLine("Latitude : " + latitude);
            System.Console.WriteLine("Longitude : " + longitude);
            System.Console.WriteLine("Message : " + response.StatusCode);

            Thread.Sleep(3000);

        
            string url2 = $"http://api.geonames.org/countrySubdivisionJSON?lat={latitude}&lng={longitude}&username=marc";

            HttpClient client2 = new HttpClient();

            HttpResponseMessage reponse2 = client2.GetAsync(url2).Result;
            string jsonResponse2 = reponse2.Content.ReadAsStringAsync().Result;

            var verPais = JsonConvert.DeserializeObject<Root2>(jsonResponse2);

            string pais = verPais.countryName;

            System.Console.WriteLine($"El pais es : {pais}");

        } while (repetir);
        

    }
}
public class IssPosition
{
    public string latitude { get; set; }
    public string longitude { get; set; }
}

public class Root
{
    public string message { get; set; }
    public int timestamp { get; set; }
    public IssPosition iss_position { get; set; }
}

public class Code
{
    public string code { get; set; }
    public string level { get; set; }
    public string type { get; set; }
}

public class Root2
{
    public List<Code> codes { get; set; }
    public string adminCode1 { get; set; }
    public int distance { get; set; }
    public int geonameId { get; set; }
    public string countryCode { get; set; }
    public int admin1geonameId { get; set; }
    public string countryName { get; set; }
    public string adminName1 { get; set; }
}








/* 

Lista de apis en github:
https://github.com/public-apis/public-apis 

*/