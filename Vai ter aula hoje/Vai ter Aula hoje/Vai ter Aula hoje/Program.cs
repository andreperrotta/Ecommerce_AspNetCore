int Aula = 0;

Console.WriteLine("Vai ter aula hoje? Digite 1 para Sim ou qualquer outro número para Não");
Aula = int.Parse(Console.ReadLine());

if (Aula == 1)
    Console.WriteLine("Vai ter aula hoje");
else
    Console.WriteLine("Não vai ter aula hoje");


