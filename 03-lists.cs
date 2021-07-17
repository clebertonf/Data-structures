// Codigo funciona somente em um ambiente com .NET core instalado
// Codigo precisa esta contido em uma classe e namesapace
// feito apenas para entendimento dos coneitos de lista

List<int> valores = new List<int>();

List<int> range = new List<int>();

for (var i = 0; i <= 10; i++)
{
    Random ale = new Random();

    int aleatorio = ale.Next(0, 10);
    range.Add(aleatorio);
}

valores.AddRange(range);
valores.Sort();
foreach (var item in valores)
{
    Console.WriteLine(item);
}
