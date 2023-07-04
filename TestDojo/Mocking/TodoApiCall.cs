using System.Net.Http.Json;

namespace TestDojo.Mocking;

public class TodoApiCall
{
    public async Task<string> GetTodoTitle(int id)
    {
        var client = new MyHttpClient();
        var todo = await client.GetAsync($"https://jsonplaceholder.typicode.com/todos/{id}");

        return (todo != null) ? todo.Title : string.Empty;
    }
}

public class MyHttpClient
{
    private readonly HttpClient _client;

    public MyHttpClient()
    {
        _client = new HttpClient();
    }
    
    public async Task<Todo?> GetAsync(string url)
    {
        var response = await _client.GetAsync(url);
        var todo = await response.Content.ReadFromJsonAsync<Todo>();
        return todo;
    }
}

public class Todo
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public bool Completed { get; set; }
}