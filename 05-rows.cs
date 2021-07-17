// Codigo funciona somente em um ambiente com .NET core instalado
// Codigo precisa esta contido em uma classe e namesapace
// feito apenas para entendimento dos conceitos de fila

Queue<string> numbers = new Queue<string>(1, 2, 3);

// adicionando item no final da fila

numbers.Enqueue(4);
numbers.Enqueue(5);

foreach (string number in numbers) {
     Console.WriteLine(item);
}


