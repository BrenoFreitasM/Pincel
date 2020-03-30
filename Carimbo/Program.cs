using System;

namespace ProgCarimbo
{
    class Program
    {
        static void Main(string[] args)
        {
			/*instância da classe carimbo*/
			Carimbo C = new Carimbo("Aprovado");
			C.carregar("Preto", 2);
			C.usar();

			C.trocarCor("Azul");
			C.usar();


			C.carregar("Preto", 2);
			C.trocarTexto("Recuperação");
			C.usar();
			
			Console.WriteLine("");
			Console.WriteLine("	 C A N E T A  ");
			Console.WriteLine("");

			Pincel D = new Pincel("Assinatura");
			D.destampar("Preta", 1);
			D.usar();

			D.destampar("Azul", 1);
			D.trocarTexto("Nova Assinatura");
			D.usar();
			

			System.Console.ReadKey();
		}
		
    }

}
