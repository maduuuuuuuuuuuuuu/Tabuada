int numero, produto;
int auxiliar = 0;
    Console.Write("Taboada do número: ");
    numero = Convert.ToInt32(Console.ReadLine()!);

while(auxiliar <= 10)
{
    produto = numero * auxiliar;
    Console.WriteLine($"{numero} x {auxiliar} = {produto}");
    auxiliar += 1;
}

