using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP.Models
{
    public interface IJogoModel
    {
        Equipa EquipaA { get; set; }
        Equipa EquipaB { get; set; }
        List<Arbitro> Arbitros { get; set; }
    }

    class Jogo : IJogoModel
    {
        #region MEMBER VARIABLES
        private Equipa equipaA;
        private Equipa equipaB;
        private List<Arbitro> arbitros;
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor Cheio
        /// </summary>
        /// <param name="equipaA">Equipa A</param>
        /// <param name="equipaB">Equipa B</param>
        /// <param name="arbitros">Equipa de Arbitros</param>
        public Jogo(Equipa equipaA, Equipa equipaB, List<Arbitro> arbitros)
        {
            this.equipaA = equipaA;
            this.equipaB = equipaB;
            this.arbitros = arbitros;
        }


        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Jogo()
        {
        }
        #endregion


        #region PROPERTIES
        /// <summary>
        /// Manipula o atributo "equipaA"
        /// </summary>
        public Equipa EquipaA
        {
            get { return equipaA; }
            set { equipaA = value; }
        }

        /// <summary>
        /// Manipula o atributo "EquipaB"
        /// </summary>
        public Equipa EquipaB
        {
            get { return equipaB; }
            set { equipaB = value; }
        }

        /// <summary>
        /// Manipula o atributo "Arbitros"
        /// </summary>
        public List<Arbitro> Arbitros
        {
            get { return arbitros; }
            set { arbitros = value; }
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
