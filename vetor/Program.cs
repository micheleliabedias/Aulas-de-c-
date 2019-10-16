/*
 * Created by SharpDevelop.
 * User: micropro
 * Date: 16/10/2019
 * Time: 20:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace vetor
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("vetor");
			int[] vetor = new int[10];
			int aux = 0;
			
			for(int count = 0;count<10;count++){
				Console.WriteLine("Digite o "+(count+1)+"° numero" );
				vetor[count] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine("Ordenando em forma crescente: \n");
			
			//Ordenando o vetor ordem crescente
			for(int i = 0; i<vetor.Length;i++){
				for(int j = i+1;j<vetor.Length;j++){
					if(vetor[i]>vetor[j]){
						aux = vetor[i];
						vetor[i] = vetor[j];
						vetor[j] = aux;
					}
				}
			}
			
			for(int i = 0; i<vetor.Length;i++){
				Console.WriteLine(vetor[i]);
			}
			
			Console.WriteLine("\n Ordenando em forma decrescente: \n");
			
			
			for(int i = 0; i<vetor.Length;i++){
				for(int j = i+1;j<vetor.Length;j++){
					if(vetor[i]<vetor[j]){
						aux = vetor[i];
						vetor[i] = vetor[j];
						vetor[j] = aux;
					}
				}
			}
			
			for(int i = 0; i<vetor.Length;i++){
				Console.WriteLine(vetor[i]);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	}
}