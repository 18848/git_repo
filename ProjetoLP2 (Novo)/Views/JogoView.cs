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
            
            //  Contar golos para cada Equipa
            int golosA = 0,  golosB = 0;
            foreach (EventoJogo item in i.EventoA)
            {
                if (item.TipoEvento == Evento.GOLO) golosA++;
            }
            foreach (EventoJogo item in i.EventoB)
            {
                if (item.TipoEvento == Evento.GOLO) golosB++;
            }

            Console.WriteLine("Equipas:");
            List<IEquipa> listEquipas = controller.GetEquipas( i.EquipaA, i.EquipaB);
            // Verificar qual equipa aparece primeiro no array das equipas referentes ao jogo
            if (controller.CheckFirstEquipas( listEquipas, i.EquipaA, i.EquipaB) == 1) // EquipaA primeiro
            {
                Console.WriteLine("\tEquipa da Casa: " + listEquipas[0].Nome + " : " + golosA.ToString() );
                Console.WriteLine("\tEquipa Visitante: " + listEquipas[1].Nome + " : " + golosB.ToString());
            }
            // EquipaB primeiro
            else
            {
                Console.WriteLine("\tEquipa da Casa: " + listEquipas[1].Nome + " : " + golosA.ToString());
                Console.WriteLine("\tEquipa Visitante: " + listEquipas[0].Nome + " : " + golosB.ToString());
            }

            Console.WriteLine("Arbitros:");
            //  Forçar Ordem dos ID's da Lista de Árbitros
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
            IEquipaController equipas = new EquipaController();
            IArbitroController arbitros = new ArbitroController();
            //List<IArbitro> arbitros = controller.GetArbitrosList();
            try
            {
                int c;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Equipas: ");
                    equipas.GetAllEquipas();
                    Console.Write("\nEquipa da Casa: ");
                    x.EquipaA = int.Parse(Console.ReadLine());
                    Console.Write("\nEquipa Visitante: ");
                    x.EquipaB = int.Parse(Console.ReadLine());
                    if(x.EquipaA == x.EquipaB)
                        Console.WriteLine("Equipas devem ser diferentes.");
                } while (x.EquipaA == x.EquipaB);

                c = 0;
                Console.WriteLine("\nArbitros: ");
                arbitros.GetAllArbitros();
                do
                {
                    Console.Write($"\n\tID-{c.ToString()}: ");
                    x.Arbitros.Add(int.Parse(Console.ReadLine()));
                    c++;
                } while (c < 5);

                do
                {
                    string evento;
                    Console.Clear();
                    Console.WriteLine("Prima 0 para sair: ");
                    Console.WriteLine("Eventos: ");
                    EventoJogo newEvento = new EventoJogo();
                    Console.WriteLine("\t Tipos de Evento: ");
                    foreach ( string e in Enum.GetNames(typeof(Evento)))
                    {
                        Console.WriteLine("{0} = {1:D}", e,
                                                     Enum.Parse(typeof(Evento), e));
                    }
                    Console.Write("\tTipo do Evento: ");
                    evento = Console.ReadLine();
                    if (0 == int.Parse(evento)) 
                        break;
                    newEvento.TipoEvento = (Evento)Enum.Parse(typeof(Evento), evento);

                    Console.WriteLine("Jogadores:");
                    IJogadorController jC= new JogadorController();
                    jC.GetAllJogadores();

                    Console.Write("\tJogador em Causa: ");
                    newEvento.Jogador = int.Parse(Console.ReadLine());

                    x.EventoA.Add(newEvento);
                } while (true);

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
