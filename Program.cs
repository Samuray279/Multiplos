Console.WriteLine("-MúltiplO-\n");
Console.Write("Digite um número...: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Avaliar se é múltiplo de:");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N1 % N2 == 0)
    Console.WriteLine($"\n{N1} é múltiplo de {N2}");
else
  Console.WriteLine($"\n{N1} não é múltiplo de {N2}");