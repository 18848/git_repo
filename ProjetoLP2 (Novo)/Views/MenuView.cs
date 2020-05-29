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
        void ArbitrosMenu();
    }

    class MenuView : IMenuView
    {
        #region Member Values
        private PessoaController pessoa;
        #endregion

        #region Constructor
        public MenuView(PessoaController p) {
            pessoa = p;
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
                    Console.WriteLine("Erro - " + e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Erro - " + e.Message);
                }

                switch (op)
                {
                    case 0:
                        pessoa.Save();
                        break;
                    case 3:
                        ArbitrosMenu();
                        break;
                    default:
                        Menu();
                        break;
                }
            } while (op != 0);
        }

        public void ArbitrosMenu()
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
                    Console.WriteLine("Erro - " + e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Erro - " + e.Message);
                }

                switch (op)
                {
                    case 0:
                        Menu();
                        break;
                    case 1:
                        Console.WriteLine("Lista de Arbitros:");
                        pessoa.GetAll();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Arbitro Especifico:");
                        pessoa.GetPessoa();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Adicionar Arbitro:");
                        pessoa.SetPessoa();
                        break;
                    case 4:
                        //Console.WriteLine("Adicionar Arbitro:");
                        pessoa.UpdatePessoa();
                        break;
                    default:
                        ArbitrosMenu();
                        break;
                }
            } while (op != 0);

        }
        #endregion
    }
}
