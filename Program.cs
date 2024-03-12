using System;

namespace MediatrêsNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int media = 60; 
            //Calculando média de 3 notas de Aluno
            //Obtendo nome do Aluno: 
            Console.WriteLine("Digite o nome do Aluno : ");
            string NomeAluno = Console.ReadLine();

            //Lendo as notas dos 3 bimestres do aluno
            Console.WriteLine("Digite a nota do Primeiro Bimestre : ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do Segundo Bimestre : ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do Terceiro Bimestre : ");
            int nota3 = int.Parse(Console.ReadLine());

            // Chamando a função para calcular a média final
            float mediaFinal = MediaFinal(nota1, nota2, nota3);

            // Exibindo o nome do aluno e a média final
            Console.WriteLine($"Nome do Aluno: {NomeAluno}");
            Console.WriteLine($"Média Final: {mediaFinal}");

            // Verifica se a média final é maior ou igual a 60
            if (mediaFinal >= media)
            {
                Console.WriteLine("Aluno Aprovado: " + NomeAluno);
                Console.WriteLine(mediaFinal);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado: " + NomeAluno);
                Console.WriteLine("Falta para ser aprovado: " + FaltaParaObterMedia(mediaFinal, media));
            }
        }

        public static float MediaFinal(int nota1, int nota2, int nota3)
        {
            // Calculando a média final com os pesos 30%, 35% e 35% 
            float mediaFinal = (nota1  + nota2   + nota3  );
            return mediaFinal;
        }

        public static int FaltaParaObterMedia(float mediaFinal, int media)
        {
            int faltaParaObterMedia = media - (int)mediaFinal; // Convertido para int
            return faltaParaObterMedia;
        }
    }
}




