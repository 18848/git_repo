using ProjetoLP2.Controllers;
using ProjetoLP2.Models;
using System;
using System.Collections.Generic;

namespace ProjetoLP2.Views
{
    public interface IEquipaView
    {
        void ShowAll(IEquipa i, int id);
        void ShowOne(IEquipa i, List<IJogador> jogadores);
        void AddEquipa();
        void GetEquipa();
        void UpdateEquipa();
        void DeleteEquipa();
        void UpdateJogador();
        void DeleteJogador();
    }

    class EquipaView : IEquipaView
    {
        #region Member Values
        private IEquipaController controller;
        #endregion

        #region Constructor
        public EquipaView(IEquipaController c)
        {
            controller = c;
            controller.SetView(this);
        }
        #endregion

        #region Functions
        public void ShowAll(IEquipa i, int id)
        {
            if (i.Active == true)
            {
                Console.WriteLine("\nID: " + id.ToString());
                Console.WriteLine("Nome: " + i.Nome);
                Console.WriteLine("Data de Fundacao: " + i.Fundacao.ToString("dd/MM/yyyy"));
            }
        }
        public void ShowOne(IEquipa i, List<IJogador> jogadores)
        {
            if (i.Active == true)
            {
                Console.WriteLine("\nNome: " + i.Nome);
                Console.WriteLine("Data de Fundacao: " + i.Fundacao.ToString("dd/MM/yyyy"));
                Console.WriteLine("\nPlantel:");

                if (jogadores != null)
                {
                    foreach (IJogador foo in jogadores)
                    {
                        Console.WriteLine("Nome: " + foo.Nome + "\tNumero: " + foo.Numero + "\tPosicao: " + foo.Posicao);
                    }
                }
            }
        }
        public void AddEquipa()
        {
            IEquipa x = new Equipa();

            try
            {
                Console.Write("\nNome: ");
                x.Nome = Console.ReadLine();

                Console.Write("Data de Fundacao: ");
                x.Fundacao = DateTime.Parse(Console.ReadLine());

                x.Active = true;

                controller.Add(x);
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }

        public void GetEquipa()
        {
            try
            {
                Console.Write("ID: ");
                int.TryParse(Console.ReadLine(), out int id);

                controller.Find(id);
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }

        public void UpdateEquipa()
        {
            IEquipa x = new Equipa();
            bool validar;

            try
            {
                Console.Write("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarEquipa(id);

                if (validar)
                {
                    Console.Write("\nNome: ");
                    x.Nome = Console.ReadLine();

                    Console.Write("Data de Fundacao: ");
                    x.Fundacao = DateTime.Parse(Console.ReadLine());

                    x.Active = true;

                    controller.Update(x);
                }

            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }

        public void DeleteEquipa()
        {
            bool validar;

            try
            {
                Console.WriteLine("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarEquipa(id);

                if (validar)
                {
                    controller.Delete();
                }

            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }

        public void UpdateJogador()
        {
            bool validarE, validarJ, sair = false;

            try
            {
                Console.Write("ID da Equipa: ");
                int.TryParse(Console.ReadLine(), out int x);
                validarE = controller.ProcurarEquipa(x);

                if (validarE)
                {
                    while (!sair)
                    {
                        Console.Write("\nID do Jogador: ");
                        int.TryParse(Console.ReadLine(), out int id);
                    
                        if(id != 0)
                        {
                            validarJ = controller.ProcurarJogador(id);

                            if (validarJ)
                            {
                                controller.UpdateJogadorModel(id);
                                Console.WriteLine("Inserido com sucesso");
                            }
                            else
                            {
                                Console.WriteLine("O jogador não pode ser selecionado");
                            }
                        }
                        else
                        {
                            sair = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("A equipa não pode ser selecionada");
                    Console.ReadKey();
                }
                
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }
        public void DeleteJogador()
        {
            bool validarE, validarJ;

            try
            {
                Console.Write("ID da Equipa: ");
                int.TryParse(Console.ReadLine(), out int x);
                validarE = controller.ProcurarEquipa(x);

                if (validarE)
                {
                    Console.Write("\nID do Jogador: ");
                    int.TryParse(Console.ReadLine(), out int id);

                    validarJ = controller.ProcurarJogador(id);

                    if (!validarJ)
                    {
                        controller.DeleteJogadorModel(id);
                        Console.WriteLine("Removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Jogador nao encontrado");
                    }
                }
                else
                {
                    Console.WriteLine("A equipa não pode ser selecionada");
                    Console.ReadKey();
                }

            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (OverflowException e)
            {
                throw e;
            }
        }
        #endregion
    }
}
