// See https://aka.ms/new-console-template for more information
Console.Write("Insira aqui o seu nome: ");
var nome = Console.ReadLine();

Console.Write("Insira aqui o dia de seu nascimento (dd/mm/yyyy): ");
var diaNascimento= Convert.ToDateTime(Console.ReadLine());

DateTime hoje = DateTime.Now; 

var idade = hoje - diaNascimento;

var idadeEmAnos = idade.Days / 365;

Console.WriteLine("Voce tem " + idadeEmAnos + " Anos");

if (idadeEmAnos < 16)
{
    Console.WriteLine("Voce nao pode tirar carteira de motorista, vai estudar! ");
} else if (idadeEmAnos >= 16 && idadeEmAnos < 18)
{
    Console.Write("Voce ja é emancipado(a) (true or false) ");
    bool isEmancipado = Convert.ToBoolean(Console.ReadLine());
    if (isEmancipado)
    {
        Console.WriteLine("Vocepode tirar a carteira de motorista, só não dirija um kwid (eu queria ter um kwid)");
    }
    else
    {
        Console.WriteLine("Voce nao pode tirar a carteira de motorista!");
    }
}
else
{
    Console.WriteLine(nome + ", Voce pode tirar carteira, bem vindo de volta, Max Verstappen!");
}