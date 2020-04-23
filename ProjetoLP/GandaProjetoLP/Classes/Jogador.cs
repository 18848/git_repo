using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GandaProjetoLP.Classes
{

    #region ENUMS
    /// <summary>
    /// Enumerado para Resultado de Operação
    /// </summary>
    enum POSICAO
    {
        ND = 0,
        GuardaRedes = 1,
        Defesa,
        Medio,
        Avancado
    }
    #endregion

    class Jogador : Pessoa
    {
        #region MEMBER VARIABLES
        private string alcunha;
        private int numero;
        private POSICAO posicao;
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor sem dados
        /// </summary>
        public Jogador(string nome, string nacionalidade, DateTime dataNascimento, float altura, float peso, string alcunha, int numero, POSICAO posicao) : base(nome, nacionalidade, dataNascimento, altura, peso)
        {
            this.alcunha = alcunha;
            this.numero = numero;
            this.posicao = posicao;
        }
        #endregion


        #region PROPERTIES
        /// <summary>
        /// Manipula o atributo "alcunha"
        /// </summary>
        public string Alcunha
        {
            get { return alcunha; }
            set { alcunha = value; }
        }

        /// <summary>
        /// Manipula o atributo "numero"
        /// </summary>
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        /// <summary>
        /// Manipula o atributo "posicao"
        /// </summary>
        public POSICAO Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
