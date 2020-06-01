using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Controllers;
using ProjetoLP2.Models;

namespace ProjetoLP2.Views
{
    public interface IEquipaView
    {
        void ShowAll(IEquipa i, int id);
        void ShowOne(IEquipa i);
        void AddEquipa();
        void GetEquipa();
        void UpdateEquipa();
        void DeleteEquipa();
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
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("Nome: " + i.Nome);
                Console.WriteLine("Data de Fundacao: " + i.Fundacao.Date);
            }
        }
        public void ShowOne(IEquipa i)
        {
            if (i.Active == true)
            {
                Console.WriteLine("Nome: " + i.Nome);
                Console.WriteLine("Data de Fundacao: " + i.Fundacao.Date);
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
                Console.WriteLine("ID: ");
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
                Console.WriteLine("ID: ");
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
        #endregion
    }
}
