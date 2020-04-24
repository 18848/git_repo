using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GandaProjetoLP.Classes
{
    #region ENUMS
    /// <summary>
    /// 
    /// </summary>
    /// 
    #endregion

    class Jogo
    {
        #region MEMBER VARIABLES
        Equipa equipaA = new Equipa();
        Equipa equipaB = new Equipa();
        //Arbitro arbitros[4] = new Arbitro();
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor cheio
        /// </summary>
        public Jogo(Equipa equipaA, Equipa equipaB, Arbitro a, Arbitro aa1, Arbitro aa2, Arbitro qa)
        {
            this.equipaA = equipaA;
            this.equipaB = equipaB;
            //this.arbitros[0] = a;
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
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
