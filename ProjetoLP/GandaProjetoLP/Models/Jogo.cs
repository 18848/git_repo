using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GandaProjetoLP.Models
{
    #region ENUMS
    #endregion

    class Jogo
    {
        #region MEMBER VARIABLES
        Equipa equipaA = new Equipa();
        Equipa equipaB = new Equipa();
        Arbitro[] arbitros = new Arbitro[4];
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor Cheio
        /// </summary>
        /// <param name="equipaA">Equipa A</param>
        /// <param name="equipaB">Equipa B</param>
        /// <param name="arbitros">Equipa de Arbitros</param>
        public Jogo(Equipa equipaA, Equipa equipaB, Arbitro[] arbitros)
        {
            this.equipaA = equipaA;
            this.equipaB = equipaB;
            for (int i = 0; i < this.arbitros.Length; i++)
            {
                this.arbitros[i] = arbitros[i];
            }
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
            get;
            set;
        }

        /// <summary>
        /// Manipula o atributo "EquipaB"
        /// </summary>
        public Equipa EquipaB
        {
            get;
            set;
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
