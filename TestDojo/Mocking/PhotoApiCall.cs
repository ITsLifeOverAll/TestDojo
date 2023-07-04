using System.Net.Http.Json;

namespace TestDojo.Mocking;

public class PhotoApiCall
{
    private const string Url = "https://jsonplaceholder.typicode.com/photos/";

    public async Task<string> GetPhotoUrlAsync(int id)
    {
        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync($"{Url}{id}");
        if (response.IsSuccessStatusCode is false)
            throw new Exception("Something went wrong");
        
        var photo = await response.Content.ReadFromJsonAsync<Photo>();
        return photo!.Url;
    }
}

public class Photo
{
    public int AlbumId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Url { get; set; } = "";
    public string ThumbnailUrl { get; set; } = "";
}
