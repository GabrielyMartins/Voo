Voo voo = new Voo(DateTime.Now, 428);
while (true)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1- Ver o próxima poltrona livre");
    Console.WriteLine("2- Verificar as poltronas");
    Console.WriteLine("3- Ocupar as poltronas");
    Console.WriteLine("4- Vagas de poltronas disponíveis");

    Console.WriteLine("Escolha um opção do menu:");
    int opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

    if (opcaoEscolhida == 1)
    {
        Console.WriteLine("A próxima poltrona livre é: " + voo.ProximoLivre());
    }
    if (opcaoEscolhida == 2)
    {
        Console.WriteLine("Informe a poltrona para verificar:");
        int poltrona = Convert.ToInt32(Console.ReadLine());
        voo.Verificar(poltrona);
    }
    if (opcaoEscolhida == 3)
    {
        Console.WriteLine("Informe a poltrona para ocupar:");
        int poltrona = Convert.ToInt32(Console.ReadLine());
        voo.Ocupar(poltrona);
    }
    if (opcaoEscolhida == 4)
    {
        Console.WriteLine("As vagas disponíveis é: " + voo.Vagas());
    }

}




