// Codigo funciona somente em um ambiente com .NET core instalado
// Codigo precisa esta contido em uma classe e namesapace
// feito apenas para entendimento dos coneitos de lista

List<int> values = new List<int>();

List<int> range = new List<int>();

for (var i = 0; i <= 10; i++)
{
    Random rand = new Random();

    int random = rand.Next(0, 10);
    range.Add(random);
}

values.AddRange(range);
values.Sort();
foreach (var item in values)
{
    Console.WriteLine(item);
}
