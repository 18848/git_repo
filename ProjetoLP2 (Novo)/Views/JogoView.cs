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
        // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void ShowAllJogos(IJogo i, int id)
        {
            List<IArbitro> arbitros = controller.GetArbitrosList(i.Arbitros);

            Console.WriteLine("\nID: " + id);

            Console.WriteLine("Equipa da Casa: " + i.EquipaA);
            Console.WriteLine("Equipa Visitante: " + i.EquipaB);
            Console.WriteLine("Equipa de Arbitros: ");
            for(int c = 0;  c < i.Arbitros.Count(); c++)
            {
                Console.WriteLine(i.Arbitros[c].ToString() + " - " + arbitros[c].Nome);
            }
        }
        public void ShowOne(IJogo i)
        {
            List<IEquipa> list = GetEquipasList();
            Console.WriteLine("\nNome: " + i.Nome);
            Console.WriteLine("Nacionalidade: " + i.Nacionalidade);
            Console.WriteLine("Data de Nascimento: " + i.DataNascimento.Date.ToString());
            Console.WriteLine("Altura: " + i.Altura);
            Console.WriteLine("Peso: " + i.Peso.ToString());
        }
        public void AddJogo()
        {
            IJogo x = new Jogo();
            List<IEquipa> list = controller.GetEquipasList();
            List<IArbitro> list = controller.GetArbitrosList();
            try
            {
                do
                {
                    for(int c = 0; c < list.Count; c++)
                    {
                        if (list[c].Active)
                        {
                            Console.WriteLine(c.ToString() + " - " + list[c].Nome);
                        }
                    }
                    Console.WriteLine("\nEquipa da Casa: ");
                    x.EquipaA = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEquipa Visitante: ");
                    x.EquipaB = int.Parse(Console.ReadLine());
                    if(x.EquipaA == x.EquipaB)
                        Console.WriteLine("Equipas devem ser diferentes.");
                } while (x.EquipaA == x.EquipaB);

                do
                {
                    int c = 0;
                    for (int c = 0; c < list.Count; c++)
                    {
                        if (list[c].Active)
                        {
                            Console.WriteLine(c.ToString() + " - " + list[c].Nome);
                        }
                    }
                    Console.WriteLine();

                }while(c < 5)

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

        public void UpdateJogo()
        {
            IJogo x = new Jogo();
            bool validar;

            try
            {
                Console.WriteLine("ID: ");
                int.TryParse(Console.ReadLine(), out int id);
                validar = controller.ProcurarJogo(id);

                if (validar)
                {
                    Console.WriteLine("\nEquipa da Casa: ");
                    x.EquipaA = int.Parse(Console.ReadLine());

                    Console.WriteLine("Equipa Visitante: ");
                    x.EquipaB = int.Parse(Console.ReadLine());

                    //Arbitros

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
