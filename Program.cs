using System;
using System.Globalization;

namespace vetores
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int n;
            Quartos[] quarto;

            Console.Write("Quantos alugueis serao registrados? ");
            n = int.Parse(Console.ReadLine());

            quarto = new Quartos[11];

            for (int i = 1; i <= n; i++){
                
				Console.WriteLine("Dados do "+ i + " Aluguel: ");
				Console.Write("Nome: ");
				string nome = Console.ReadLine();
				Console.Write("Email: ");
				string email = Console.ReadLine();
				Console.WriteLine("Quarto: ");
				int quartoEscolhido = int.Parse(Console.ReadLine());

                quarto[quartoEscolhido] = new Quartos(nome, email);
            }
			
            Console.WriteLine();
            Console.WriteLine("--Quartos--");

            for (int i = 1; i <= 10; i++){
                if(quarto[i] != null){
                    Console.WriteLine(i + ": " + quarto[i]);
                } 
            }

            Console.ReadLine();
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			//int n;
			//Produto[] novoProduto;
			
			//n = int.Parse(Console.ReadLine());
			//novoProduto = new Produto[n];
			
			//double soma = 0;
			
			//for (int i = 0; i < n;i++){
			//    double idade = double.Parse(Console.ReadLine());
			//    novoProduto[i] = new Produto(idade);
			//    soma += novoProduto[i].idade;
			//}
			
			//double media = soma / n;
			
			//Console.WriteLine("media: " + media);
			
			
			
			
		}
	}
}

