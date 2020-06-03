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
        private EquipaController equipa;
        private JogoController jogo;
        private CompeticaoController competicao;
        #endregion

        #region Constructor
        public MenuView(JogadorController j, ArbitroController a, EquipaController e, JogoController jo, CompeticaoController c) 
        {
            jogador = j;
            arbitro = a;
            equipa = e;
            jogo = jo;
            competicao = c;
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
                    case 1:
                        //ArbitroMenu();
                        break;
                    case 2:
                        //ArbitroMenu();
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
                    case 6:
                        //JogoMenu();
                        break;
                    case 7:
                        //CompeticaoMenu();
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
                arbitro.Save();

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
                jogador.Save();

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
                    Console.WriteLine("\n1: Ver Lista de Equipas");
                    Console.WriteLine("2: Ver Plantel da Equipa");
                    Console.WriteLine("3: Inserir Equipa");
                    Console.WriteLine("4: Inserir Plantel");
                    Console.WriteLine("5: Editar Equipa");
                    Console.WriteLine("6: Remover Equipa");
                    Console.WriteLine("7: Remover Jogadores da Equipa");
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
                        Console.WriteLine("Lista de Equipas:");
                        equipa.GetAllEquipas();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Plantel da Equipa:");
                        equipa.GetEquipa();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Adicionar Equipa:");
                        equipa.SetEquipa();
                        break;
                    case 4:
                        Console.WriteLine("Adicionar Plantel: (0 para sair)");
                        equipa.UpdateJogador();
                        break;
                    case 5:
                        Console.WriteLine("Editar Equipa:");
                        equipa.UpdateEquipa();
                        break;
                    case 6:
                        Console.WriteLine("Remover Equipa:");
                        equipa.DeleteEquipa();
                        break;
                    case 7:
                        Console.WriteLine("Remover Jogador da Equipa:");
                        equipa.DeleteJogador();
                        break;
                }
                equipa.Save();

            } while (op != 0);
        }
        public void JogoMenu()
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------- Menu --------------------");
                    Console.WriteLine("_------------------- Jogo --------------------");
                    Console.WriteLine("\n1: Ver Lista de Jogos da Competição");
                    Console.WriteLine("2: Inserir Jogo");
                    //Console.WriteLine("3: Inserir Jogo na Jornada");
                    Console.WriteLine("4: Editar Jogo");
                    //Console.WriteLine("5: Remover Equipa");
                    //Console.WriteLine("6: Remover Jogadores da Equipa");
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
                        Console.WriteLine("Lista de Jornadas:");
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
                jogo.Save();

            } while (op != 0);
        }
        #endregion
    }
}
