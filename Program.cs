using System.Net.Http.Json;

const string endpoint = "https://catfact.ninja/fact";

try
{
  using HttpClient httpClient = new();
  CatFact? catFact = await httpClient.GetFromJsonAsync<CatFact>(endpoint);

  if (catFact is null || string.IsNullOrWhiteSpace(catFact.Fact))
  {
    Console.WriteLine("A API não retornou um fato válido sobre gatos.");
    return;
  }

  Console.WriteLine("Fato sobre Gatos:");
  Console.WriteLine(catFact.Fact);
}
catch (HttpRequestException exception)
{
  Console.WriteLine($"Não foi possível consultar a API: {exception.Message}");
}

public sealed class CatFact
{
  public string Fact { get; init; } = string.Empty;
}
