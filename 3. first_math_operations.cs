// Novo projeto: Usar o método Math para verificar o maior entre dois numeros.

// Inicializando estilização (rudimentar):

string startTab = "(::::::::::::::::::::::::::::::::::::::::::)";

// Inicializando os valores numéricos a serem comparados:

int firstValue = 500;
int secondValue = 600;

// Executando as operações com a classe Math.
int largerValue = Math.Max(firstValue, secondValue);    // Método Max permite detectar o maior dos dois.
int lesserValue = Math.Min(firstValue, secondValue);   // Método Min permkite detectar o menor dos dois.
var multiValue = Math.Pow(firstValue, secondValue);   // Método Pow faz uma exponenciação dos dois valores.
var logFirstValue = Math.Log(firstValue);            // Método Log faz um logarítimo natural para o valor.
var logSecondValue = Math.Log(secondValue);

// Supormos um número decimal:
double numero = 5.09192739;
var numeroInteiro = Math.Round(numero, 0);      // Método Round mostra apenas uma quantidade especificada de casas decimais.

// Output do programa:

Console.WriteLine($"{startTab}\n");
Console.WriteLine($"Temos dois números inteiros: {firstValue} e {secondValue} .\n");
Console.WriteLine($"O maior número é {largerValue}.");
Console.WriteLine($"O menor número é {lesserValue}.");
Console.WriteLine($"Ao elevarmos ambos os números, temos: {multiValue}.\n");
Console.WriteLine($"Os logarítimos natuarais de ambos são {Math.Round(logFirstValue, 4)} e {Math.Round(logSecondValue, 4)}.");
Console.WriteLine($"A parte inteira do número {numero} é {numeroInteiro}.");
Console.WriteLine($"\n{startTab}");
