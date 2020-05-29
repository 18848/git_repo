using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Controllers;
using ProjetoLP2.Models;

namespace ProjetoLP2.Views
{
    public interface IPessoaView
    {
        void ShowAll(IPessoa i, int id);
        void ShowOne(IPessoa i);
        void AddPessoa();
        void GetPessoa(); 
        void UpdatePessoa();
    }

    class PessoaView : IPessoaView
    {
        #region Member Values
        private IPessoaController controller;
        #endregion

        #region Constructor
        public PessoaView(IPessoaController c) //Instancia a view e o controlador
        {
            controller = c;
            controller.SetView(this);
        }
        #endregion

        #region Functions
        public void ShowAll(IPessoa i, int id)
        {   if(i.Active == true)
            {   
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("Nome: " + i.Nome);
                Console.WriteLine("Nacionalidade: " + i.Nacionalidade);
            }
        }
        public void ShowOne(IPessoa i)
        {
            Console.WriteLine("\nNome: " + i.Nome);
            Console.WriteLine("Nacionalidade: " + i.Nacionalidade);
            Console.WriteLine("Data de Nascimento: " + i.DataNascimento.Date.ToString());
            Console.WriteLine("Altura: " + i.Altura);
            Console.WriteLine("Peso: " + i.Peso.ToString());
        }
        public void AddPessoa()
        {
            IPessoa x = new Pessoa();

            try
            {
                Console.WriteLine("\nNome: ");
                x.Nome = Console.ReadLine();

                Console.WriteLine("Nacionalidade: ");
                x.Nacionalidade = Console.ReadLine();

                Console.WriteLine("Data de Nascimento: ");
                x.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Altura: ");
                float.TryParse(Console.ReadLine(), out float altura);
                x.Altura = altura;

                Console.WriteLine("Peso: ");
                float.TryParse(Console.ReadLine(), out float peso);
                x.Peso = peso;

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

        public void GetPessoa()
        {
            try
            {
                Console.WriteLine("Pesquisar Pessoa:");
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

        public void UpdatePessoa()
        {
            IPessoa x = new Pessoa();
            bool validar;

            try
            {
                Console.WriteLine("Editar Pessoa:");
                Console.WriteLine("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarCliente(id);

                if (validar)
                {
                    Console.WriteLine("\nNome: ");
                    x.Nome = Console.ReadLine();

                    Console.WriteLine("Nacionalidade: ");
                    x.Nacionalidade = Console.ReadLine();

                    Console.WriteLine("Data de Nascimento: ");
                    x.DataNascimento = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Altura: ");
                    float.TryParse(Console.ReadLine(), out float altura);
                    x.Altura = altura;

                    Console.WriteLine("Peso: ");
                    float.TryParse(Console.ReadLine(), out float peso);
                    x.Peso = peso;

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
        #endregion
    }
}
