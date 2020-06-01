using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Controllers;

namespace ProjetoLP2.Views
{
    public interface IMenuView
    {
        void Menu(); 
        void ArbitroMenu();
        void JogadorMenu();
        void EquipaMenu();

    }

    class MenuView : IMenuView
    {
        #region Member Values
        private JogadorController jogador;
        private ArbitroController arbitro;
        #endregion

        #region Constructor
        public MenuView(JogadorController j, ArbitroController a) 
        {
            jogador = j;
            arbitro = a;
        }
        #endregion

        #region Functions
        public void Menu()
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------- Menu --------------------");
                    Console.WriteLine("\n1: Classificacao");
                    Console.WriteLine("2: Estatisticas");
                    Console.WriteLine("3: Arbitros");
                    Console.WriteLine("4: Jogadores");
                    Console.WriteLine("5: Equipas");
                    Console.WriteLine("6: Competicao");
                    Console.WriteLine("7: Jogo");
                    Console.WriteLine("0: Sair");
                    Console.Write("\nOpcao: ");
                    int.TryParse(Console.ReadLine(), out op);
                }
                catch (FormatException e)
                {
                    throw e;
                }
                catch (OverflowException e)
                {
                    throw e;
                }

                switch (op)
                {
                    case 0:
                        arbitro.Save();
                        jogador.Save();
                        break;
                    case 3:
                        ArbitroMenu();
                        break;
                    case 4:
                        JogadorMenu();
                        break;
                    case 5:
                        EquipaMenu();
                        break;
                    default:
                        Menu();
                        break;
                }
            } while (op != 0);
        }

        public void ArbitroMenu()
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------- Menu --------------------");
                    Console.WriteLine("------------------ Arbitro -------------------");
                    Console.WriteLine("\n1: Ver Lista de Arbitros");
                    Console.WriteLine("2: Ver Arbitro Especifico");
                    Console.WriteLine("3: Inserir Arbitro");
                    Console.WriteLine("4: Editar Arbitro");
                    Console.WriteLine("5: Remover Arbitro");
                    Console.WriteLine("0: Voltar");
                    Console.Write("\nOpcao: ");
                    int.TryParse(Console.ReadLine(), out op);
                    Console.Clear();
                }
                catch (FormatException e)
                {
                    throw e;
                }
                catch (OverflowException e)
                {
                    throw e;
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Lista de Arbitros:");
                        arbitro.GetAllArbitros();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Arbitro Especifico:");
                        arbitro.GetArbitro();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Adicionar Arbitro:");
                        arbitro.SetArbitro();
                        break;
                    case 4:
                        Console.WriteLine("Editar Arbitro:");
                        arbitro.UpdateArbitro();
                        break;
                    case 5:
                        Console.WriteLine("Remover Arbitro:");
                        arbitro.DeleteArbitro();
                        break;
                }
            } while (op != 0);
        }

        public void JogadorMenu()
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------- Menu --------------------");
                    Console.WriteLine("------------------ Jogador -------------------");
                    Console.WriteLine("\n1: Ver Lista de Jogadores");
                    Console.WriteLine("2: Ver Jogador Especifico");
                    Console.WriteLine("3: Inserir Jogador");
                    Console.WriteLine("4: Editar Jogador");
                    Console.WriteLine("5: Remover Jogador");
                    Console.WriteLine("0: Voltar");
                    Console.Write("\nOpcao: ");
                    int.TryParse(Console.ReadLine(), out op);
                    Console.Clear();
                }
                catch (FormatException e)
                {
                    throw e;
                }
                catch (OverflowException e)
                {
                    throw e;
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Lista de Jogadores:");
                        jogador.GetAllJogadores();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Jogador Especifico:");
                        jogador.GetJogador();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Adicionar Jogador:");
                        jogador.SetJogador();
                        break;
                    case 4:
                        Console.WriteLine("Editar Jogador:");
                        jogador.UpdateJogador();
                        break;
                    case 5:
                        Console.WriteLine("Remover Jogador:");
                        jogador.DeleteJogador();
                        break;
                }
            } while (op != 0);
        }
        public void EquipaMenu()
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------- Menu --------------------");
                    Console.WriteLine("------------------- Equipa -------------------");
                    Console.WriteLine("\n1: Ver Lista de Jogadores da Equipa");
                    Console.WriteLine("2: Inserir Equipa");
                    Console.WriteLine("3: Inserir Jogador na Equipa");
                    Console.WriteLine("4: Editar Equipa");
                    Console.WriteLine("5: Remover Equipa");
                    Console.WriteLine("6: Remover Jogadores da Equipa");
                    Console.WriteLine("0: Voltar");
                    Console.Write("\nOpcao: ");
                    int.TryParse(Console.ReadLine(), out op);
                    Console.Clear();
                }
                catch (FormatException e)
                {
                    throw e;
                }
                catch (OverflowException e)
                {
                    throw e;
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Lista de Jogadores:");
                        jogador.GetAllJogadores();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Jogador Especifico:");
                        jogador.GetJogador();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Adicionar Jogador:");
                        jogador.SetJogador();
                        break;
                    case 4:
                        Console.WriteLine("Editar Jogador:");
                        jogador.UpdateJogador();
                        break;
                    case 5:
                        Console.WriteLine("Remover Jogador:");
                        jogador.DeleteJogador();
                        break;
                }
            } while (op != 0);
        }
        #endregion
    }
}
