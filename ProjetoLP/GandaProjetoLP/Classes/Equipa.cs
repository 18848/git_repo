using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

    class Equipa
    {
        #region MEMBER VARIABLES
        private string nome;
        private DateTime fundacao;
        static Jogador[] jogadores;
        int totJogadores = 0;
        int max;
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor cheio
        /// </summary>
        public Equipa(string nome, DateTime fundacao, int max)
        {
            this.nome = nome;
            this.fundacao = fundacao;
            this.max = max;
            jogadores = new Jogador[max];
        }


        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Equipa()
        {
            this.nome = "";
            this.fundacao = DateTime.Now;
        }
        #endregion


        #region PROPERTIES
        /// <summary>
        /// Manipula o atributo "nome"
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Manipula o atributo "fundacao"
        /// </summary>
        public DateTime Fundacao
        {
            get { return fundacao; }
            set { fundacao = value; }
        }

        /// <summary>
        /// Manipula o atributo "max"
        /// </summary>
        public int Max
        {
            get { return max; }
            set { max = value; }
        }
        #endregion


        #region FUNCTIONS
        /// <summary>
        /// Registar um jogador novo na equipa
        /// </summary>
        /// <param name="jogador"></param>
        /// <returns></returns>
        public int InserirJogador(Jogador jogador)
        {
            if (totJogadores >= max) return 0;

            jogadores[totJogadores++] = jogador;
            return 1;
        }
        #endregion


        #region OVERIDES
        #endregion
    }
}