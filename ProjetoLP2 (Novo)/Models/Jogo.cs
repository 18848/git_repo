﻿using System;
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

        void UpdateJogo(IJogo jogo);
    }

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
            Arbitros = null;
        }

        #endregion


        #region PROPERTIES
        
        /// <summary>
        /// Manipula o atributo "equipaA"
        /// </summary>
        public int EquipaA
        {
            get { return equipaA; }
            set { equipaA = value; }
        }

        /// <summary>
        /// Manipula o atributo "EquipaB"
        /// </summary>
        public int EquipaB
        {
            get { return equipaB; }
            set { equipaB = value; }
        }

        /// <summary>
        /// Manipula o atributo "Arbitros"
        /// </summary>
        public List<int> Arbitros
        {
            get { return arbitros; }
            set { arbitros = value; }
        }
        
        #endregion


        #region FUNCTIONS

        public void UpdateJogo(IJogo jogo)
        {
            EquipaA = jogo.EquipaA;
            EquipaB = jogo.EquipaB;
            Arbitros = jogo.Arbitros;
        }

        #endregion

    }
}