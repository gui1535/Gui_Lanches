using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lanches_Gui
{
    internal class Program
    {
        // Variaveis Para Cliente
        static int CodigoCliente;
        static string NomeCliente;
        static string LancheCliente;
        static int ValorCliente;

        // Lista de para os pedidos
        static List<PedidoLanche> pedidos = new List<PedidoLanche>();

        // Enumeração para o menu
        enum Menu { Pedidos = 1, OrdemConfeccao = 2 }

        // Enumeração para o sim ou nao
        enum SimNao { Sim = 1, Nao = 2 }

        // Enumeração para os pedidos
        enum Pedido { GravarPedido = 1, ExibirPedidos = 2 }

        // Estrutura Lanhces
        struct PedidoLanche
        {
            public string NmCli;
            public int Cod;
            public string Lch;
            public int Vlr;

            // construtor da Struct
            public PedidoLanche(int codigo, string nomecli, string lanche, int valor)
            {
                Cod = codigo;
                NmCli = nomecli;
                Lch = lanche;
                Vlr = valor;
            }
        }

        // Principal
        static void Main(string[] args)
        {
            try // Tent fazer isso
            {
                Inicio();
            }
            catch (Exception)
            {
                MessageBox.Show("Ops! Ocorreu um erro, verifique os valores digitados", "Gui_Lanches", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Console.ReadKey();
        }

        // Responsavel por pedidos do cliente
        static void PedidoCliente()
        {

                // Codigo do cliente
                Console.WriteLine($"Codigo do pedido: ");
                CodigoCliente = int.Parse(Console.ReadLine());

                // Nome do cliente
                Console.WriteLine($"Nome do cliente: ");
                NomeCliente = Console.ReadLine();

                // Lanche do cliente
                Console.WriteLine($"Lanche do cliente: ");
                LancheCliente = Console.ReadLine();

                // Valor do cliente
                Console.WriteLine($"Valor do cliente: ");
                ValorCliente = int.Parse(Console.ReadLine());

            // Adicionar Valores na lista
            pedidos.Add(new PedidoLanche(CodigoCliente, NomeCliente, LancheCliente, ValorCliente));

                // Exibir valores
                foreach (PedidoLanche l in pedidos)
                {
                    Console.WriteLine($"Codigo: {CodigoCliente} ----> Cliente: {NomeCliente} | Lanche: {LancheCliente} | Valor: {ValorCliente}");
                    Console.WriteLine();
                }

                // Usuario deseja cadastrar outro?
                Console.WriteLine("Deseja gravar mais um pedido? \n 1 - Sim \n 2 - Não");

                // Uma variavel do tipo Menu, chamada de SimNao, é convertida para um numero do tipo Menu
                SimNao OpcaoGravarPedido = (SimNao)int.Parse(Console.ReadLine());

                // Casos
                switch (OpcaoGravarPedido)
                {
                    case SimNao.Sim:
                        Console.Clear();
                        PedidoCliente();
                        break;
                    case SimNao.Nao:
                        Console.Clear();
                        Inicio();
                        break;
                }
            
        }

        // Inicio
        static void Inicio()
        {
            // Mensagem Inicio
            Console.WriteLine("-----> Ola, seja bem vindo <-----");
            Console.WriteLine("Selecione uma das opções: \n 1 - Pedidos \n 2 - Ordem confecção");

            // Uma variavel do tipo Menu, chamada de OpcaoInicial, é convertida para um numero do tipo Menu
            Menu OpcaoInicial = (Menu)int.Parse(Console.ReadLine());

            // Casos
            switch (OpcaoInicial)
            {
                case Menu.Pedidos:
                    PedidoCliente();
                    break;
                case Menu.OrdemConfeccao:
                    OrdemConfec();
                    break;
            }
        }

        // Ordem de confecção dos lanches
        static void OrdemConfec()
        {
            foreach (PedidoLanche l in pedidos)
            {
                Console.WriteLine($"Codigo: {CodigoCliente} ----> Cliente: {NomeCliente} | Lanche: {LancheCliente} | Valor: {ValorCliente}");
                
            }
        }
    }
}
