using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP.Controllers;
using ProjetoLP.Models;

namespace ProjetoLP.View
{
    public interface IMenuView
    {
        void MainMenu();
        void ClassificacaoMenu();
        void EstatisticasMenu();
        void ArbitrosMenu();
        void JogadoresMenu();
        void EquipasMenu();
        void JogosMenu();
        void CompeticaoMenu();
    }

    class MenuView : IMenuView
    {

        private ArbitroController arbitroController;
        private JogadorController jogadorController;
        private EquipaController equipaController;
        private CompeticaoController competicaoController;

        #region Constructor
        public MenuView()
        {
            //arbitroController = new ArbitroController();
            //jogadorController = new JogadorController();
            //equipaController = new EquipaController();
            //competicaoController = new CompeticaoController();
        }
        #endregion


        #region Properties
        public void MainMenu()
        {
            int op = 0;

            do
            {
                
                try
                {
                    Console.Clear();
                    Console.WriteLine("-------------------- Menu --------------------");
                    Console.WriteLine("1: Classificacao");
                    Console.WriteLine("2: Estatisticas");
                    Console.WriteLine("3: Arbitros");
                    Console.WriteLine("4: Jogadores");
                    Console.WriteLine("5: Equipas");
                    Console.WriteLine("6: Competicao");
                    Console.WriteLine("7: Jogo");
                    Console.WriteLine("0: Sair");
                    Console.Write("Opcao: ");
                    int.TryParse(Console.ReadLine(), out op);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erro - " + e);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Erro - " + e);
                }

                switch (op)
                {
                    case 1:
                        ClassificacaoMenu();
                        break;
                    case 2:
                        EstatisticasMenu();
                        break;
                    case 3:
                        ArbitrosMenu();
                        break;
                    case 4:
                        JogadoresMenu();
                        break;
                    case 5:
                        EquipasMenu();
                        break;
                    case 6:
                        JogosMenu();
                        break;
                    case 7:
                        CompeticaoMenu();
                        break;
                    //case 0:
                    //    MainMenu();
                    //    break;
                }
            } while (op != 0);
        }



        public void ClassificacaoMenu()
        {
            Console.Clear();
            Console.WriteLine("Classificacao");
            Console.ReadLine();
        }
        public void EstatisticasMenu()
        {
            Console.Clear();
            Console.WriteLine("Estatisticas");
            Console.ReadLine();
        }
                
        public void ArbitrosMenu()
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1: Lista de Arbitros");
                    Console.WriteLine("2: Arbitro Especifico");
                    Console.WriteLine("3: Adicionar Arbitro");
                    Console.WriteLine("4: Editar Arbitro");
                    Console.WriteLine("5: Remover Arbitro");
                    Console.WriteLine("0: Voltar");
                    Console.WriteLine("Opcao: ");
                    int.TryParse(Console.ReadLine(), out op);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erro - " + e);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Erro - " + e);
                }

                Console.Clear();
                switch (op)
                {
                    case 1:
                        try
                        {
                            //Console.WriteLine(arbitro.GetNome());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        break;

                    case 2:
                        try
                        {
                            List<Arbitro> arbitros = new List<Arbitro>(); //Carregar apartir de um getter
                            Arbitro arbitro = new Arbitro();
                            Console.WriteLine("Insira o nome do arbitro");
                            arbitro.Nome = Console.ReadLine();

                            //Associar o arbitro ao controller Not Done
                            Console.WriteLine("Nome: " + arbitroController.GetNome());
                            Console.WriteLine("Data Nascimento: " + arbitroController.GetDataNascimento());
                            Console.WriteLine("Nacionalidade: " + arbitroController.GetNacionalidade());
                            Console.WriteLine("Altura: " + arbitroController.GetAltura());
                            Console.WriteLine("Peso: " + arbitroController.GetPeso());
                            Console.WriteLine("Associacao: " + arbitroController.GetAssociacao());
                            Console.WriteLine("Categoria: " + arbitroController.GetCategoria());
                            Console.WriteLine("Data de Formacao: " + arbitroController.GetFormacao());
                            
                        }
                        catch (NullReferenceException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        break;
                }

                Console.ReadKey();

            } while (op != 0);
        }
        public void JogadoresMenu()
        {
            int op = 0;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1: Lista de Jogadores");
                    Console.WriteLine("2: Jogador Especifico");
                    Console.WriteLine("3: Adicionar Jogador");
                    Console.WriteLine("4: Editar Jogador");
                    Console.WriteLine("5: Remover Jogador");
                    Console.WriteLine("6: Transferir Jogador");
                    Console.WriteLine("0: Voltar");
                    Console.WriteLine("Opcao: ");
                    int.TryParse(Console.ReadLine(), out op);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Erro - " + e);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Erro - " + e);
                }

                Console.Clear();
                switch (op)
                {
                    case 1:
                        try
                        {
                            //Console.WriteLine(arbitro.GetNome());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        break;

                    case 2:
                        try
                        {
                            List<Jogador> jogadores = new List<Jogador>(); //Carregar apartir de um getter
                            Jogador jogador = new Jogador();
                            //Console.WriteLine("Insira o nome do arbitro");
                            //arbitro.Nome = Console.ReadLine();

                            //Associar o arbitro ao controller Not Done

                            Console.WriteLine("Nome: " + arbitroController.GetNome());
                            Console.WriteLine("Data Nascimento: " + arbitroController.GetDataNascimento());
                            Console.WriteLine("Nacionalidade: " + arbitroController.GetNacionalidade());
                            Console.WriteLine("Altura: " + arbitroController.GetAltura());
                            Console.WriteLine("Peso: " + arbitroController.GetPeso());
                            Console.WriteLine("Associacao: " + arbitroController.GetAssociacao());
                            Console.WriteLine("Categoria: " + arbitroController.GetCategoria());
                            Console.WriteLine("Data de Formacao: " + arbitroController.GetFormacao());
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine("Erro - " + e);
                        }
                        break;
                }

                Console.ReadKey();

            } while (op != 0);
        }
        public void EquipasMenu()
        {
            Console.Clear();
            Console.WriteLine("Equipas");
            Console.ReadLine();
        }
        public void JogosMenu()
        {
            Console.Clear();
            Console.WriteLine("Jogos");
            Console.ReadLine();
        }
        public void CompeticaoMenu()
        {
            Console.Clear();
            Console.WriteLine("Competicao");
            Console.ReadLine();
        }



        #endregion
    }
}
