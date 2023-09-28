using Services;

var configuration = new GitHubConfiguration();
var gitHubService = new GitHubService(configuration);

string user = "Tincho-dev";

var User = await gitHubService.GetUser(user);

Console.WriteLine($"User: {User.Name} ({User.Login})");