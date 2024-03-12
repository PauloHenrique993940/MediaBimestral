using System;

namespace MediatrêsNotas.obj
{
    public class CalculoMediatresBimestre
    {
        public class Aluno
        {
            public string Nome { get; set; }
            public int Nota1 { get; set; }
            public int Nota2 { get; set; }
            public int Nota3 { get; set; }

            public float MediaFinal()
            {
                // Calculando a média final com os pesos 30%, 35% e 35% 
                return (Nota1 * 0.3f + Nota2 * 0.35f + Nota3 * 0.35f);
            }

            public bool Aprovado(int mediaMinima)
            {
                return MediaFinal() >= mediaMinima;
            }

            public int FaltaParaObterMedia(int mediaMinima)
            {
                int faltaParaObterMedia = (int)(mediaMinima - MediaFinal() + 0.5f); // Arredonda para cima
                return faltaParaObterMedia;
            }
        }

        public static void Main(string[] args)
        {
            int mediaMinima = 60;

            // Criando uma instância da classe Aluno
            Aluno aluno = new Aluno();

            // Obtendo nome do Aluno
            Console.WriteLine("Digite o nome do Aluno : ");
            aluno.Nome = Console.ReadLine();

            // Lendo as notas dos 3 bimestres do aluno
            Console.WriteLine("Digite a nota do Primeiro Bimestre : ");
            aluno.Nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do Segundo Bimestre : ");
            aluno.Nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota do Terceiro Bimestre : ");
            aluno.Nota3 = int.Parse(Console.ReadLine());

            // Exibindo o nome do aluno e a média final
            Console.WriteLine($"Nome do Aluno: {aluno.Nome}");
            Console.WriteLine($"Média Final: {aluno.MediaFinal()}");

            // Verifica se a média final é maior ou igual à média mínima
            if (aluno.Aprovado(mediaMinima))
            {
                Console.WriteLine("Aluno Aprovado: " + aluno.Nome);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado: " + aluno.Nome);
                Console.WriteLine("Falta para ser aprovado: " + aluno.FaltaParaObterMedia(mediaMinima));
            }
        }
    }
}

