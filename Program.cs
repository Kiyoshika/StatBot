using Discord;
using Discord.WebSocket;

public class Program
{
    public static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

    private DiscordSocketClient _client;
    public async Task MainAsync()
    {
        _client = new DiscordSocketClient();
        var token = File.ReadAllText("bottoken.cfg");

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();

        await Task.Delay(-1);
    }
}