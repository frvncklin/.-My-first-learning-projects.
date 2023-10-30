// Novo projeto: Usar o método Math para verificar o maior entre dois numeros.

// Inicializando estilização (rudimentar):

string startTab = "(::::::::::::::::::::::::::::::::::::::::::)";

// Inicializando os valores numéricos a serem comparados:

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
int lesserValue = Math.Min(firstValue, secondValue);
var multiValue = Math.Pow(firstValue, secondValue);
var logFirstValue = Math.Log(firstValue);
var logSecondValue = Math.Log(secondValue);

// Supormos um número decimal:
double numero = 5.09192739;
var numeroInteiro = Math.Round(numero, 0);

// Output do programa:

Console.WriteLine($"{startTab}\n");
Console.WriteLine($"Temos dois números inteiros: {firstValue} e {secondValue} .\n");
Console.WriteLine($"O maior número é {largerValue}.");
Console.WriteLine($"O menor número é {lesserValue}.");
Console.WriteLine($"Ao elevarmos ambos os números, temos: {multiValue}.\n");
Console.WriteLine($"Os logarítimos natuarais de ambos são {Math.Round(logFirstValue, 4)} e {Math.Round(logSecondValue, 4)}.");
Console.WriteLine($"A parte inteira do número {numero} é {numeroInteiro}.");
Console.WriteLine($"\n{startTab}");