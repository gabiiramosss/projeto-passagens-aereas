//Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

//Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.

//O sistema deve exibir um menu com as seguintes opções:
//1- Cadastrar passagem
//2- Listar Passagens
//0- Sair

Console.WriteLine($"Bem-vindo a Gabi Airlines! Vamos começar seu atendimento.");

int indexPassageiro = 0;
string[] passageiro = new string [5];
string[] origem = new string [5];
string[] destino = new string [5];
string[] data = new string [5];

Console.WriteLine($"Primeiramente digite a sua senha numérica: ");
int senha = int.Parse(Console.ReadLine());

while (senha != 123456)
{
    Console.WriteLine($"Senha incorreta! Digite novamente:");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine(@$"
Agora selecione a opção desejada:
1 - Cadastrar Passagem
2 - Listar Passagens
0- Sair");
char escolha = char.Parse(Console.ReadLine());

while(escolha != '0')
{
    Console.WriteLine(@$"
    Agora selecione a opção desejada:
    1 - Cadastrar Passagem
    2 - Listar Passagens
    0- Sair");
    escolha = char.Parse(Console.ReadLine());

    switch (escolha)
    {
        case '1':
            Console.WriteLine($"Insira seu nome: ");
            passageiro[indexPassageiro] = Console.ReadLine();
            Console.WriteLine($"Qual a origem do voo?: ");
            origem[indexPassageiro] = Console.ReadLine();
            Console.WriteLine($"Qual o destino do voo?: ");
            destino[indexPassageiro] = Console.ReadLine();
            Console.WriteLine($"Qual a data do voo?: ");
            data[indexPassageiro] = Console.ReadLine();
            indexPassageiro++;
            Console.WriteLine($"Ótimo! Sua passagem foi cadastrada");
            break;

        case '2':
            for (int i = 0; i < indexPassageiro; i++)
            {
                Console.WriteLine($"{passageiro}");  
                Console.WriteLine($"{origem}");  
                Console.WriteLine($"{destino}");  
                Console.WriteLine($"{data}");  
            }
            break;

        case '0':
            Console.WriteLine($"Volte sempre! :)");
            break;
    }
}