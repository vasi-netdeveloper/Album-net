using Album_C_;
using Newtonsoft.Json;

var client = new HttpClient();

HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/photos?albumId=3");

if (response.IsSuccessStatusCode)
{
    string responseBody = await response.Content.ReadAsStringAsync();
    var albums = JsonConvert.DeserializeObject<List<AlbumJsonData>>(responseBody);

    Console.WriteLine("photo-album 3");

    albums?.ForEach(a => Console.WriteLine("[{0}] {1}", a.Id, a.Title));

}
else
{
    Console.WriteLine("No data found");
}
