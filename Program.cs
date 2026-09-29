int opcao=0;
double salario;
int meses;

do
{
    Console.WriteLine("Escolha uma das opções abaixo");
    Console.WriteLine("1. Novo salario");
    Console.WriteLine("2. Férias");
    Console.WriteLine("3. Décimo Terceiro");
    Console.WriteLine("4. Sair");

    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {

        Console.WriteLine("Digite seu salario");
        salario = double.Parse(Console.ReadLine());

        if (salario <= 350.00)
        {
            salario *= 1.15;
            Console.WriteLine($"O seu novo salário é {salario}");

        }

        else if (salario <= 650.00)
        {
            salario *= 1.10;
            Console.WriteLine($"O seu novo salário é {salario}");
        }

        else

        {
            salario *= 1.05;
            Console.WriteLine($"O seu novo salário é {salario}");
        }
    }

    else if (opcao == 2)
    {

        Console.WriteLine("Digite seu salario");
        salario = double.Parse(Console.ReadLine());

        salario *= 1.5;

        Console.WriteLine($"O valor das ferias é {salario}");
    }

    else if (opcao == 3) 
    {

        Console.WriteLine("Digite seu salario");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de meses trabalhados no ultimo ano");
        meses = int.Parse(Console.ReadLine());

        if (meses < 1 || meses > 12)
        {
            Console.WriteLine("Numero invalido");

            while (meses < 1 || meses > 12) 
            {
                Console.WriteLine("Digite a quantidade de meses trabalhados no ultimo ano");
                meses = int.Parse(Console.ReadLine());
            }

            salario = (salario * meses) / 12;

            Console.WriteLine($"Decimo terceiro a receber {salario}");

        }

        
  
    }
    

}


while (opcao!=4);