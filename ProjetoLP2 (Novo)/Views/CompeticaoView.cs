using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;
using ProjetoLP2.Controllers;

namespace ProjetoLP2.Views
{
    public interface ICompeticaoView
    {
        void ShowAll(ICompeticao i, int id);
        void ShowOne(ICompeticao i, List<IEquipa> equipas);
        void AddCompeticao();
        void GetCompeticao();
        void UpdateCompeticao();
        void DeleteCompeticao();
        void UpdateEquipa();
        void DeleteEquipa();
    }

    class CompeticaoView : ICompeticaoView
    {
        #region Member Values
        private ICompeticaoController controller;
        #endregion

        #region Constructor
        public CompeticaoView(ICompeticaoController c)
        {
            controller = c;
            controller.SetView(this);
        }
        #endregion

        #region Functions
        public void ShowAll(ICompeticao i, int id)
        {
            if (i.Active == true)
            {
                Console.WriteLine("\nID: " + id.ToString());
                Console.WriteLine("Nome: " + i.Nome);
                Console.WriteLine("Data de Inicio: " + i.Inicio.ToString("dd/MM/yyyy"));
                Console.WriteLine("Data de Fim: " + i.Inicio.ToString("dd/MM/yyyy"));
            }
        }
        public void ShowOne(ICompeticao i, List<IEquipa> equipas)
        {
            if (i.Active == true)
            {
                Console.WriteLine("\nNome: " + i.Nome);
                Console.WriteLine("Data de Inicio: " + i.Inicio.ToString("dd/MM/yyyy"));
                Console.WriteLine("Data de Fim: " + i.Inicio.ToString("dd/MM/yyyy"));
                Console.WriteLine("\nEquipas:");

                if (equipas != null)
                {
                    foreach (IEquipa foo in equipas)
                    {
                        Console.WriteLine("Nome: " + foo.Nome);
                    }
                }
            }
        }
        public void AddCompeticao()
        {
            ICompeticao x = new Competicao();

            try
            {
                Console.Write("\nNome: ");
                x.Nome = Console.ReadLine();

                Console.Write("Data de Inicio: ");
                x.Inicio = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de Fim: ");
                x.Fim = DateTime.Parse(Console.ReadLine());

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

        public void GetCompeticao()
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

        public void UpdateCompeticao()
        {
            ICompeticao x = new Competicao();
            bool validar;

            try
            {
                Console.Write("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarCompeticao(id);

                if (validar)
                {
                    Console.Write("\nNome: ");
                    x.Nome = Console.ReadLine();

                    Console.Write("Data de Inicio: ");
                    x.Inicio = DateTime.Parse(Console.ReadLine());

                    Console.Write("Data de Fim: ");
                    x.Fim = DateTime.Parse(Console.ReadLine());

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
                validar = controller.ProcurarCompeticao(id);

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

        public void UpdateEquipa()
        {
            bool validarE, validarJ, sair = false;

            try
            {
                Console.Write("ID da Competicao: ");
                int.TryParse(Console.ReadLine(), out int x);
                validarE = controller.ProcurarCompeticao(x);

                if (validarE)
                {
                    while (!sair)
                    {
                        Console.Write("\nID da Equipa: ");
                        int.TryParse(Console.ReadLine(), out int id);

                        if (id != 0)
                        {
                            validarJ = controller.ProcurarEquipa(id);

                            if (validarJ)
                            {
                                controller.UpdateJogadorModel(id);
                                Console.WriteLine("Inserido com sucesso");
                            }
                            else
                            {
                                Console.WriteLine("A equipa não pode ser selecionado");
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
                    Console.WriteLine("A competicao não pode ser selecionada");
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
        public void DeleteEquipa()
        {
            bool validarE, validarJ;

            try
            {
                Console.Write("ID da Competicao: ");
                int.TryParse(Console.ReadLine(), out int x);
                validarE = controller.ProcurarCompeticao(x);

                if (validarE)
                {
                    Console.Write("\nID da Equipa: ");
                    int.TryParse(Console.ReadLine(), out int id);

                    validarJ = controller.ProcurarEquipa(id);

                    if (!validarJ)
                    {
                        controller.DeleteEquipaModel(id);
                        Console.WriteLine("Removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Equipa nao encontrada");
                    }
                }
                else
                {
                    Console.WriteLine("A competicao não pode ser selecionada");
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
