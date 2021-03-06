﻿using Series.Classes;
using System;

namespace Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper()!= "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Você não possui nenhuma série cadastrada ainda! :(");
                return;
            }

            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0} - {1} {2}", serie.retornaId(), serie.retornaTitulo(),(excluido ? "** Excluido **" : ""));
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite  a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Inserir(novaSerie);
        }

        private static void AtualizarSerie()
        {
            var lista = repositorio.Lista();
           

            Console.WriteLine("Digite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            if (lista.Count == 0)
            {
                Console.WriteLine("ERRO!! Id não localizado!!");
                return;
            }

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o genêro da série: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite  a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

           

            repositorio.Atualizar(indiceSerie,atualizaSerie);
        }

        private static void ExcluirSerie()
        {
            var lista = repositorio.Lista();
           
            Console.WriteLine("Digite o id da série para excluir: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            if (lista.Count == 0)
            {
                Console.WriteLine("ERRO!! Não foi possivel localizar o registro!");
                return;
            }

            if(indiceSerie != lista.Count)
            {
                Console.WriteLine("ERRO!!! Id não localizado.");
                return;
            }

            repositorio.Excluir(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada! :(");
                return;
            }

            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornoPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("******** Catalogo DIO Séries ******** ");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
