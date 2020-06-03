using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;

namespace ProjetoLP2.Models
{
    public interface IJogo
    {
        int EquipaA { get; set; }
        int EquipaB { get; set; }
        List<int> Arbitros { get; set; }
        int ResultadoA { get; set; }
        int ResultadoB { get; set; }


        void UpdateJogo(IJogo jogo);
        void UpdateArbitro(int id);
        void DeleteArbitro(int id);
    }

    [Serializable]
    public class Jogo : IJogo
    {
        #region MEMBER VARIABLES
        private int equipaA;
        private int equipaB;
        private List<int> arbitros;
        private int resultadoA;
        private int resultadoB;
        #endregion

        #region CONSTRUCTORS
        public Jogo()
        {
            EquipaA = 0;
            EquipaB = 0;
            Arbitros = new List<int>();
            ResultadoA = 0;
            ResultadoB = 0;
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
        public int ResultadoA { get; set; }
        public int ResultadoB { get; set; }
        #endregion

        #region FUNCTIONS
        public void UpdateJogo(IJogo jogo)
        {
            EquipaA = jogo.EquipaA;
            EquipaB = jogo.EquipaB;
            ResultadoA = jogo.ResultadoA;
            ResultadoB = jogo.ResultadoB;
        }

        public void UpdateArbitro(int id)
        {
            if (Arbitros == null)
            {
                Arbitros = new List<int>();
            }

            Arbitros.Add(id);
        }

        public void DeleteArbitro(int id)
        {
            Arbitros.Remove(id);
        }
        #endregion

    }
}
