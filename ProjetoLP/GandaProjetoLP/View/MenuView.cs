using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP.Controllers;

namespace ProjetoLP.View
{
    public interface IMenuView
    {
        void MainMenu();
        void ArbitroMenu();
    }

    class MenuView : IMenuView
    {

        private readonly IArbitroController controllerArbitro;

        #region Constructor
        public MenuView(){}
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

                switch (op)
                {
                    case 1:
                        ArbitroMenu();
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
            } while (op != 0);

            Console.Clear();
            switch (op)
            {
                case 1:
                    //controllerArbitro
                    break;
            }
        }
        #endregion
    }
}
