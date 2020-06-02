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
            List<IArbitro> arbitros = controller.GetArbitros(i.Arbitros);

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
            Console.WriteLine("Equipas:");
            List<IEquipa> listEquipas = controller.GetEquipas( i.EquipaA, i.EquipaB);
            if (controller.CheckFirstEquipas( listEquipas, i.EquipaA, i.EquipaB) == 1)
            {
                Console.WriteLine("\tEquipa da Casa: " + i.EquipaA.ToString() + " - " + listEquipas[0].Nome);
                Console.WriteLine("\tEquipa Visitante: " + i.EquipaB.ToString() + " - " + listEquipas[1].Nome);
            }
            else
            {
                Console.WriteLine("\tEquipa da Casa: " + i.EquipaA.ToString() + " - " + listEquipas[1].Nome);
                Console.WriteLine("\tEquipa Visitante: " + i.EquipaB.ToString() + " - " + listEquipas[0].Nome);
            }

            Console.WriteLine("Arbitros:");
            i.Arbitros.Sort();
            List<IArbitro> listArbitros = controller.GetArbitros(i.Arbitros);
            for (int c = 0; c < listArbitros.Count; c++)
            {
                Console.WriteLine("\t- " + i.Arbitros[c].ToString() + " - " + listArbitros[c].Nome + " - " + listArbitros[c].Categoria.ToString());
            }
        }
        public void AddJogo()
        {
            IJogo x = new Jogo();
            List<IEquipa> equipas = controller.GetEquipasList();
            List<IArbitro> arbitros = controller.GetArbitrosList();
            try
            {
                int c;
                do
                {
                    for(c = 0; c < equipas.Count; c++)
                    {
                        if (equipas[c].Active)
                        {
                            Console.WriteLine(c.ToString() + " - " + equipas[c].Nome);
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
                    for (c = 0; c < arbitros.Count; c++)
                    {
                        if (arbitros[c].Active)
                        {
                            Console.WriteLine(c.ToString() + " - " + arbitros[c].Nome);
                            Console.WriteLine("\t- " + arbitros[c].Categoria);
                            Console.WriteLine("\t- " + arbitros[c].Categoria + "\n");
                        }
                    }
                    Console.WriteLine();

                } while (c < 5);

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

        public void GetJogo()
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
