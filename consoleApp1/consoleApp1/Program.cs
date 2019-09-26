/*
 * Created by SharpDevelop.
 * User: micropro
 * Date: 26/09/2019
 * Time: 15:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace consoleApp1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string nome;
			string CPF;
			string RG;
			string dataNascimento;
			
			int idade;
			char sexo;
			double altura;
			double peso;
			
			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine("	Cadastro de pessoa");
			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine("Digite o nome");
			Console.BackgroundColor = ConsoleColor.Blue;
			nome = Console.ReadLine();
			Console.BackgroundColor = ConsoleColor.Black;
			
			
			Console.WriteLine("Digite o CPF");
			Console.BackgroundColor = ConsoleColor.Blue;
			CPF = Console.ReadLine();
			Console.BackgroundColor = ConsoleColor.Black;
			
			
			Console.WriteLine("Digite o RG");
			Console.BackgroundColor = ConsoleColor.Blue;
			RG = Console.ReadLine();
			Console.BackgroundColor = ConsoleColor.Black;
			
			
			Console.WriteLine("Digite a data de nascimento");
			Console.BackgroundColor = ConsoleColor.Blue;
			dataNascimento = Console.ReadLine();
			Console.BackgroundColor = ConsoleColor.Black;
			
			Console.WriteLine("Digite a idade");
			Console.BackgroundColor = ConsoleColor.Blue;
			idade = Convert.ToInt32(Console.ReadLine());
			Console.BackgroundColor = ConsoleColor.Black;
			
			Console.WriteLine("Digite o sexo");
			Console.BackgroundColor = ConsoleColor.Blue;
			sexo = Convert.ToChar(Console.ReadLine());
			Console.BackgroundColor = ConsoleColor.Black;
			
			Console.WriteLine("Digite a altura");
			Console.BackgroundColor = ConsoleColor.Blue;
			altura = Convert.ToDouble(Console.ReadLine());
			Console.BackgroundColor = ConsoleColor.Black;
			
			Console.WriteLine("Digite o peso");
			Console.BackgroundColor = ConsoleColor.Blue;
			peso = Convert.ToDouble(Console.ReadLine());
			Console.BackgroundColor = ConsoleColor.Black;
			
			
			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine("DADOS CADASTRADOS ");
			Console.WriteLine("-----------------------------------------------------");
			Console.WriteLine("Nome: "+nome);
			Console.WriteLine("CPF: "+CPF);
			Console.WriteLine("RG: "+RG);
			Console.WriteLine("Data de nascimento: "+dataNascimento);
			Console.WriteLine("Idade: "+idade);
			Console.WriteLine("Sexo: "+sexo);
			Console.WriteLine("Altura: "+altura);
			Console.WriteLine("Peso: "+peso);
			Console.WriteLine("-----------------------------------------------------");
			
			Console.WriteLine("Aperte uma tecla para sair");
			
			Console.ReadKey();
		
		}
	}
}