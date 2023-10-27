// Iremos fazer outro teste com sobrecarregamento de métodos, usando como base o programa anterior de rolamento de dados.

// Inicialização de variáveis de apresentação.
string presenter = "(:::::::::::::::::::::::::::::::::::::::::::::)";
string slasher = "------------#";
string blank = "        ";
string introMessage = "...Testing method overload...";

// Cabeçalho de apresentação.

Console.WriteLine($"{presenter}\n");
Console.WriteLine($"{blank}{introMessage}\n");

// Rolagem dos dados abstratos:

Random dice = new Random();          // Criei uma nova instãncia para a classe random.
int roll01 = dice.Next();           // Vou recuperar um valor proporcionado pelo método Next a partir da variável dice. Não há limite.
int roll02 = dice.Next(101);       // Vou recuperar um valor aleatório até o limite máximo 101.
int roll03 = dice.Next(50, 101);  // Vou recuperar um valor entre o limite mínimo de 50 e máximo de 101.

// Resultado e impressão:

Console.WriteLine($"{blank}  Estes são meus rolamentos:{blank}\n");
Console.WriteLine($"{slasher} Rolamento 1: {roll01}");
Console.WriteLine($"{slasher} Rolamento 2: {roll02}");
Console.WriteLine($"{slasher} Rolamento 3: {roll03}");
Console.WriteLine($"\n{presenter}");



