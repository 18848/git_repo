using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Controllers;
using ProjetoLP2.Models;

namespace ProjetoLP2.Views
{
    public interface IJogadorView
    {
        void ShowAll(IJogador i, int id);
        void ShowOne(IJogador i);
        void AddJogador();
        void GetJogador();
        void UpdateJogador();
        void DeleteJogador();
    }

    class JogadorView : IJogadorView
    {
        #region Member Values
        private IJogadorController controller;
        #endregion

        #region Constructor
        public JogadorView(IJogadorController c)
        {
            controller = c;
            controller.SetView(this);
        }
        #endregion

        #region Functions
        public void ShowAll(IJogador i, int id)
        {
            if (i.Active == true)
            {
                Console.WriteLine("\nID: " + id);
                Console.WriteLine("Nome: " + i.Nome);
                Console.WriteLine("Nacionalidade: " + i.Nacionalidade);
            }
        }
        public void ShowOne(IJogador i)
        {
            if (i.Active == true)
            {
                Console.WriteLine("\nNome: " + i.Nome);
                Console.WriteLine("Nacionalidade: " + i.Nacionalidade);
                Console.WriteLine("Data de Nascimento: " + i.DataNascimento.Date.ToString());
                Console.WriteLine("Altura: " + i.Altura);
                Console.WriteLine("Peso: " + i.Peso.ToString());
                Console.WriteLine("Alcunha: " + i.Alcunha);
                Console.WriteLine("Numero: " + i.Numero.ToString());
                Console.WriteLine("Posicao: " + i.Posicao);
            }
        }
        public void AddJogador()
        {
            IJogador x = new Jogador();

            try
            {
                Console.Write("\nNome: ");
                x.Nome = Console.ReadLine();

                Console.Write("Nacionalidade: ");
                x.Nacionalidade = Console.ReadLine();

                Console.Write("Data de Nascimento: ");
                x.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                if(float.TryParse(Console.ReadLine(), out float altura))
                {
                    x.Altura = altura;
                }

                Console.Write("Peso: ");
                if(float.TryParse(Console.ReadLine(), out float peso))
                {
                    x.Peso = peso;
                }

                Console.Write("Alcunha: ");
                x.Alcunha = Console.ReadLine();

                Console.Write("Numero: ");
                if(int.TryParse(Console.ReadLine(), out int numero))
                {
                    x.Numero = numero;
                }

                Console.WriteLine("\nPosicoes: ");
                foreach (string foo in Enum.GetNames(typeof(POSICAO)))
                {
                    Console.WriteLine("\t" + foo);
                }

                Console.Write("\nPosicao: ");
                if(Enum.TryParse(Console.ReadLine(), out POSICAO posicao))
                {
                    x.Posicao = posicao;
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

        public void GetJogador()
        {
            try
            {
                Console.Write("\nID: ");
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

        public void UpdateJogador()
        {
            IJogador x = new Jogador();
            bool validar;

            try
            {
                Console.Write("\nID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarJogador(id);

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

                    Console.Write("Alcunha: ");
                    x.Alcunha = Console.ReadLine();

                    Console.Write("Numero: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                    {
                        x.Numero = numero;
                    }

                    Console.WriteLine("\nPosicoes: ");
                    foreach (string foo in Enum.GetNames(typeof(POSICAO)))
                    {
                        Console.WriteLine("\t" + foo);
                    }

                    Console.Write("\nPosicao: ");
                    if (Enum.TryParse(Console.ReadLine(), out POSICAO posicao))
                    {
                        x.Posicao = posicao;
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

        public void DeleteJogador()
        {
            bool validar;

            try
            {
                Console.Write("\nID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarJogador(id);

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
