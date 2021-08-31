using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestArrayInt();
            // TestArrayContaCorrente();
            // TestListaDeContaCorrente();
            // TestListaDeContaCorrenteIndexadores();
            TestListaDeContaCorrenteParams();


            // Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));
            // Console.WriteLine(SomarVarios(1, 2, 45));

            Console.ReadLine();
        }

        public static void TestListaDeContaCorrenteParams()
        {
           // ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {

                //ContaCorrente teste = lista["texto"];

                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }


        public static void TestListaDeContaCorrenteIndexadores()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente(10);

            ContaCorrente contaDoGui = new ContaCorrente(111, 111111111);

            lista.Adicionar(contaDoGui);

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));

            Console.WriteLine("");

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posicao {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        public static void TestListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(111, 111111111);

            lista.Adicionar(contaDoGui);

            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 5679787));


            lista.EscreverListaNaTela();

            lista.Remover(contaDoGui);

            lista.EscreverListaNaTela();
        }

        public static void TestArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[] {
                 new ContaCorrente(874, 5679787),
                 new ContaCorrente(874, 4479787),
                 new ContaCorrente(874, 7789787)
            };



            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        public static void TestArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine("");

            Console.WriteLine("Média " + media);

        }

        public static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
    }
}
