// Faça uma calculadora para uma casa de tintas. 
Console.WriteLine("--- Casa de Tinta ---\n");

const double LATA = 18;
const double GALAO = 3.6;
const double RENDIMENTO = 3;
const double MARGEM = 1.1;



Console.Write("Digite a área a ser pintada (m²)...: ");
double area = double.Parse(Console.ReadLine()!);

double tintaNecessaria = area / RENDIMENTO * MARGEM;
int lataNecessaria = (int)Math.Ceiling(tintaNecessaria / LATA);
int galoesNecessarios = (int)Math.Ceiling(tintaNecessaria / GALAO);

Console.WriteLine($"\nQuantidade de tinta necessária.....: {tintaNecessaria} litro(s)\n");
Console.WriteLine($"Número de latas necessária.........: {lataNecessaria} unidade(s)");
Console.WriteLine($"Número de galões necessário........: {galoesNecessarios} unidade(s)");