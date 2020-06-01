using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;
using ProjetoLP2.Controllers;
using ProjetoLP2.Models.Guardar;

namespace ProjetoLP2.Views
{
    public interface IJogoView
    {
        void ShowAllJogos(IJogo i, int id);
        void ShowOne(IJogo i);
        void AddJogo();
        void GetJogo();
        void UpdateJogo();
    }
    public class JogoView : IJogoView
    {
        #region Member Values
        
        private IJogoController controller;
        
        #endregion

        #region Constructor
        public JogoView(IJogoController c) 
        {
            controller = c;
            controller.SetView(this);
        }
        #endregion

        #region Functions
        public void ShowAllJogos(IJogo i, int id)
        {
            IGuardaArbitro arbitros = new GuardaArbitro();
            arbitros.Load("arbitros.bin");

            Console.WriteLine("\nID: " + id);
            Console.WriteLine("Equipa da Casa: " + i.EquipaA.Nome);
            Console.WriteLine("Equipa Visitante: " + i.EquipaB.Nome);
            Console.WriteLine("Equipa de Arbitros: ");
            foreach (int x in i.Arbitros)
            {
                IArbitro a = arbitros.Find(x);
                Console.WriteLine(x.ToString() + " - " + a.Nome);
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
                Console.WriteLine("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarPessoa(id);

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

        public void DeletePessoa()
        {
            bool validar;

            try
            {
                Console.WriteLine("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarPessoa(id);

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
