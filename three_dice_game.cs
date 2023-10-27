// Criando aplicativo de jogo de dados.

// Estamos conhecendo o metodo system Random.

string slashModel = "==========";
string mensagemInicial = $"\n{slashModel}{slashModel}Iniciando jogo de dados{slashModel}{slashModel}\n";
Console.WriteLine(mensagemInicial);

Random dice01 = new Random();
int roll01 = dice01.Next(1, 7);
Random dice02 = new Random();
int roll02 = dice02.Next(1, 7);
Random dice03 = new Random();
int roll03 = dice03.Next(1, 7);
int somaRoll = roll01 + roll02 + roll03;

Console.WriteLine($"O primeiro dado resultou em {roll01}");
Console.WriteLine($"O segundo dado resultou em {roll02}");
Console.WriteLine($"O terceiro dado resultou em {roll03}");
Console.WriteLine($"\nNo total, temos, para você, o número {somaRoll}.\n\nDesejamos muita sorte!!\n\n\n{slashModel}{slashModel}");


// Eu defini o dice como um número aleatório novo ('new') a ser gerado e, então, defini o rolo dele ('roll') como um número de 1 a 7
// gerado pelo Dice, usando a função Next. Importante notar que o roll é um inteiro, então só poderemos pegar 7 números.
// 1, 2, 3, 4, 5, 6 e 7.
// Random.Next é um método que simula o lançamento de um número aleatório.