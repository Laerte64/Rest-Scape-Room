using Story;
using System.Text.Json;

var file = File.ReadAllText("roteiro.json");
var roteiro = JsonSerializer.Deserialize<Roteiro>(file);
roteiro!.Apresentar();









