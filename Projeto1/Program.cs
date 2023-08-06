void mensagem()
{

    Console.WriteLine(@"
██╗░░██╗██╗████████╗  ███╗░░██╗██╗░░░██╗███╗░░░███╗██████╗░███████╗██████╗░
██║░░██║██║╚══██╔══╝  ████╗░██║██║░░░██║████╗░████║██╔══██╗██╔════╝██╔══██╗
███████║██║░░░██║░░░  ██╔██╗██║██║░░░██║██╔████╔██║██████╦╝█████╗░░██████╔╝
██╔══██║██║░░░██║░░░  ██║╚████║██║░░░██║██║╚██╔╝██║██╔══██╗██╔══╝░░██╔══██╗
██║░░██║██║░░░██║░░░  ██║░╚███║╚██████╔╝██║░╚═╝░██║██████╦╝███████╗██║░░██║
╚═╝░░╚═╝╚═╝░░░╚═╝░░░  ╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝");
      
}

int menu()
{
    Console.WriteLine("\nDigite 1 para começar o jogo \nDigite 2 para ver o score \nDigite 0 para sair");
    Console.Write("\n\nQual opção deseja?");
    
    string opcaoMenu = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoMenu);   
    switch (opcaoEscolhidaNum)
    {
        case 0: Console.WriteLine("\nPrograma encerrando...");
            break; 
        case 1: Console.WriteLine("\nO jogo começou!");
            break;
        case 2: Console.WriteLine("");
            break;
        default: Console.WriteLine("\nOpção inexistente");
            break;
    }
    return (opcaoEscolhidaNum);
}

void jogo()
{
    mensagem();
    int opcao = menu();

    switch (opcao)
    {
        case 1: 
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);
            int numeroEscolhido;
        
            do
            {
                Console.Write("\nDigite um número de 1 a 100!");
                string numeroEscolhidoString = Console.ReadLine();
                numeroEscolhido = int.Parse(numeroEscolhidoString);
            
                if (numeroEscolhido == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                } else if (numeroEscolhido > numeroAleatorio)
                {
                    Console.WriteLine($"Quase! O número {numeroEscolhido} é maior!");
                } else if (numeroEscolhido < numeroAleatorio)
                {
                    Console.WriteLine($"Quase! O número {numeroEscolhido} é menor!");
                } else
                {
                    Console.WriteLine("Não estou te entendendo!");
                }
            } while (numeroEscolhido != numeroAleatorio);
        
            Console.WriteLine(@"
█░█░█ █ █▄░█ █▄░█ █▀▀ █▀█
▀▄▀▄▀ █ █░▀█ █░▀█ ██▄ █▀▄");
            break;
        case 2:
            break;


        default:
            Console.WriteLine("O jogo acabou!");
            break;
    }
}
jogo();