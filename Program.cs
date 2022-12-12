Console.WriteLine("PROGRAMAÇÃO DO CAIXA");
Thread.Sleep(1800);
Console.WriteLine("--------------//--------------");
Thread.Sleep(1800);

Console.WriteLine("   --- CAIXA ELETRÔNICO  ---");

Console.WriteLine("--------------//--------------");
Console.Beep();

Thread.Sleep(1500);


Console.WriteLine("NOTAS NESTE CAIXA: ");
Console.WriteLine("R$2, R$5, R$10 , R$ 20, R$ 50,R$ 100 e R$ 200 Reais");



Thread.Sleep(1500);

 
Console.WriteLine("BANCOS DISPONIVEIS PARA SAQUE  ");


Thread.Sleep(1500);

Console.ForegroundColor = ConsoleColor.DarkMagenta ;
Console.Write(1);Console.WriteLine("- NUBANK ");



Thread.Sleep(1500);


Console.ForegroundColor = ConsoleColor.Red;
Console.Write(2);Console.WriteLine("- BRADESCO ");



Thread.Sleep(1500);


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write(3);Console.WriteLine("- CAIXA ECONOMICA FEDERAL ");



Thread.Sleep(1500);


Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write(4);Console.WriteLine("- C6 BANK  ");



Thread.Sleep(1500);

Console.ResetColor();

Console.Write("DIGITE O SEU BANCO  : ");

Console.Beep();



int n1 = Convert.ToInt32(Console.ReadLine());
tentenovamente(n1);

void tentenovamente (int x)
{
    if (x == 1)
    {
        Console.WriteLine("BANCO DISPONIVEL");
    }
    else if (x == 2)
    {
        Console.WriteLine("BANCO DISPONIVEL");

    }
    else if (x == 3)
    {
        Console.WriteLine("BANCO DISPONIVEL");

    }
    else if (x == 4)
    {
        Console.WriteLine("BANCO DISPONIVEL");

    }
    else if (x >= 5)
    {
        Console.WriteLine("BANCO INDISPONÍVEL");
    }
if (n1 < 5)
{

Console.Write("DIGITE O VALOR: ");
decimal valorsaque = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nAGUARDE AS CONTAGEM DA NOTAS\n ");
Thread.Sleep(1500);
Console.Beep();
Console.Beep();

Thread.Sleep(1500);

Console.WriteLine("NOTAS DISPONIVEIS!! RETIRE AO LADO !!");
Console.Beep();
Console.Beep();
Console.Beep();

Thread.Sleep(1800);
}
else
{
   Console.WriteLine("Não existe esse banco, digite novamente");
   n1 = Convert.ToInt32(Console.ReadLine());
tentenovamente(n1);
 
}
}