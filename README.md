# Cat Facts Console App

Aplicação de console em C# que consulta a [Cat Facts API](https://catfact.ninja/) e exibe um fato aleatório sobre gatos no terminal.

## Funcionalidades

- Faz uma requisição HTTP GET para `https://catfact.ninja/fact`
- Desserializa a resposta JSON diretamente em um objeto tipado (`CatFact`)
- Exibe o fato retornado
- Trata falhas de conexão/requisição (`HttpRequestException`) e respostas vazias ou inválidas

## Estrutura do código

```
├── Program.cs
```

### Principais componentes

| Componente | Descrição |
|---|---|
| `endpoint` | Endpoint da API de fatos sobre gatos |
| `HttpClient` | Cliente HTTP usado para a requisição |
| `CatFact` | Modelo que representa o objeto retornado pelo JSON, contendo a propriedade `Fact` |

## Como executar

1. Clone ou copie o código para um projeto de console .NET:
   ```bash
   dotnet new console -n CatFactsApp
   cd CatFactsApp
   ```
2. Substitua o conteúdo de `Program.cs` pelo código deste repositório.
3. Execute a aplicação:
   ```bash
   dotnet run
   ```

## Licença

Defina a licença do seu projeto aqui (ex: MIT, Apache 2.0, etc).
