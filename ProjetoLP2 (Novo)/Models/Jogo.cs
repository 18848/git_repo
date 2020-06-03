using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;

namespace ProjetoLP2.Models
{
    [Serializable]
    public enum Evento
    {
        GOLO = 1, CA, CV
    }
    [Serializable]
    public struct EventoJogo
    {
        public EventoJogo(Evento e, int j)
        {
            TipoEvento = e;
            Jogador = j;
        }
        public Evento TipoEvento { get; set; }
        public int Jogador { get; set; }
    }
    public interface IJogo
    {
        int EquipaA { get; set; }
        int EquipaB { get; set; }
        List<int> Arbitros { get; set; }
        List<EventoJogo> EventoA { get; set; }
        List<EventoJogo> EventoB { get; set; }

        void UpdateJogo(IJogo jogo);
    }
    [Serializable]
    public class Jogo : IJogo
    {

        #region MEMBER VARIABLES
        
        private int equipaA;
        private int equipaB;
        private List<int> arbitros;

        
        #endregion


        #region CONSTRUCTORS

        /// <summary>
        /// The Default Constructur.
        /// </summary>
        public Jogo()
        {
            EquipaA = 0;
            EquipaB = 0;
            Arbitros = new List<int>();
            EventoA = new List<EventoJogo>();
            EventoB = new List<EventoJogo>();
        }

        #endregion


        #region PROPERTIES
        
        /// <summary>
        /// Manipula o atributo "equipaA"
        /// </summary>
        public int EquipaA { get; set; }

        /// <summary>
        /// Manipula o atributo "EquipaB"
        /// </summary>
        public int EquipaB { get; set; }

        /// <summary>
        /// Manipula o atributo "Arbitros"
        /// </summary>
        public List<int> Arbitros { get; set; }
        public List<EventoJogo> EventoA { get; set; }
        public List<EventoJogo> EventoB { get; set; }

        #endregion


        #region FUNCTIONS

        public void UpdateJogo(IJogo jogo)
        {
            EquipaA = jogo.EquipaA;
            EquipaB = jogo.EquipaB;
            Arbitros = jogo.Arbitros;
            EventoA = jogo.EventoA;
            EventoB = jogo.EventoB;
        }

        #endregion

    }
}
