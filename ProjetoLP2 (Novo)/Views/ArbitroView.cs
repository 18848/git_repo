using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Controllers;
using ProjetoLP2.Models;


namespace ProjetoLP2.Views
{
    public interface IArbitroView
    {
        void ShowAllArbitros(IArbitro i, int id);
        void ShowOneArbitro(IArbitro i);
        void AddArbitro();
        void GetArbitro();
        void UpdateArbitro();
        void DeleteArbitro();
    }
    public class ArbitroView : IArbitroView
    {
        #region Member Values
        private IArbitroController controller;
        #endregion

        #region Constructor
        public ArbitroView(IArbitroController c) 
        {
            controller = c;
            controller.SetView(this);
        }
        #endregion

        #region Functions
        public void ShowAllArbitros(IArbitro i, int id)
        {
            if (i.Active == true)
            {
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("Nome: " + i.Nome);
                Console.WriteLine("Nacionalidade: " + i.Nacionalidade);
            }
        }
        public void ShowOneArbitro(IArbitro i)
        {
            Console.WriteLine("\nNome: " + i.Nome);
            Console.WriteLine("Nacionalidade: " + i.Nacionalidade);
            Console.WriteLine("Data de Nascimento: " + i.DataNascimento.Date.ToString());
            Console.WriteLine("Altura: " + i.Altura);
            Console.WriteLine("Peso: " + i.Peso.ToString());
            Console.WriteLine("Data de Formação: " + i.Formacao.ToString());
            Console.WriteLine("Categoria: " + i.Categoria);
            Console.WriteLine("Associação: " + i.Associacao);
        }
        public void AddArbitro()
        {
            IArbitro x = new Arbitro();

            try
            {
                Console.Write("\nNome: ");
                x.Nome = Console.ReadLine();

                Console.Write("Nacionalidade: ");
                x.Nacionalidade = Console.ReadLine();

                Console.Write("Data de Nascimento: ");
                x.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                if (float.TryParse(Console.ReadLine(), out float altura))
                {
                    x.Altura = altura;
                }

                Console.Write("Peso: ");
                if (float.TryParse(Console.ReadLine(), out float peso))
                {
                    x.Peso = peso;
                }

                Console.Write("Data de Formação: ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime formacao))
                {
                    x.Formacao = formacao;
                }

                Console.WriteLine("\nCategorias: ");
                foreach (string foo in Enum.GetNames(typeof(CATEGORIA)))
                {
                    Console.WriteLine("\t" + foo);
                }

                Console.Write("\nCategoria: ");
                if ( Enum.TryParse(Console.ReadLine(), out CATEGORIA categoria))
                {
                    x.Categoria = categoria;
                }

                Console.WriteLine("\nAssociacoes: ");
                foreach (string foo in Enum.GetNames(typeof(ASSOCIACAO)))
                {
                    Console.WriteLine("\t" + foo);
                }

                Console.Write("\nAssociação: ");
                if (Enum.TryParse(Console.ReadLine(), out ASSOCIACAO associacao))
                {
                    x.Associacao = associacao;
                }

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

        public void GetArbitro()
        {
            try
            {
                Console.WriteLine("ID: ");
                int id = int.Parse(Console.ReadLine());

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

        public void UpdateArbitro()
        {
            IArbitro x = new Arbitro();
            bool validar;

            try
            {
                Console.WriteLine("ID: ");
                int.TryParse(Console.ReadLine(), out int id);

                validar = controller.ProcurarArbitro(id);
                
                if (validar)
                {

                    Console.Write("\nNome: ");
                    x.Nome = Console.ReadLine();

                    Console.Write("Nacionalidade: ");
                    x.Nacionalidade = Console.ReadLine();

                    Console.Write("Data de Nascimento: ");
                    x.DataNascimento = DateTime.Parse(Console.ReadLine());

                    Console.Write("Altura: ");
                    if (float.TryParse(Console.ReadLine(), out float altura))
                    {
                        x.Altura = altura;
                    }

                    Console.Write("Peso: ");
                    if (float.TryParse(Console.ReadLine(), out float peso))
                    {
                        x.Peso = peso;
                    }

                    Console.Write("Data de Formação: ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime formacao))
                    {
                        x.Formacao = formacao;
                    }

                    Console.WriteLine("\nCategorias: ");
                    foreach (string foo in Enum.GetNames(typeof(CATEGORIA)))
                    {
                        Console.WriteLine("\t" + foo);
                    }

                    Console.Write("\nCategoria: ");
                    if (Enum.TryParse(Console.ReadLine(), out CATEGORIA categoria))
                    {
                        x.Categoria = categoria;
                    }

                    Console.WriteLine("\nAssociacoes: ");
                    foreach (string foo in Enum.GetNames(typeof(ASSOCIACAO)))
                    {
                        Console.WriteLine("\t" + foo);
                    }

                    Console.Write("\nAssociação: ");
                    if (Enum.TryParse(Console.ReadLine(), out ASSOCIACAO associacao))
                    {
                        x.Associacao = associacao;
                    }

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

        public void DeleteArbitro()
        {
            bool validar;

            try
            {
                Console.WriteLine("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarArbitro(id);

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
