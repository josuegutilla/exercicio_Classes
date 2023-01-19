using System.Globalization;

namespace ex_classes_objetos_atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pessoa1, pessoa2;

            //pessoa1 = new Pessoa();
            //pessoa2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.Write("Nome: ");
            //pessoa1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoa1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa: ");
            //Console.Write("Nome: ");
            //pessoa2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //pessoa2.Idade = int.Parse(Console.ReadLine());

            //if (pessoa1.Idade > pessoa2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            //}


            Console.WriteLine("---------------------------------");


            Funcionario func1, func2;

            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salMedio = (func1.Salario + func2.Salario) / 2;

            Console.WriteLine("Salário médio = " + salMedio, CultureInfo.InvariantCulture);
        }
    }
}
