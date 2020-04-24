using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GandaProjetoLP.Classes
{
    #region ENUMS 
    #endregion

    class Equipa
    {
        #region MEMBER VARIABLES
        private string nome;
        private DateTime fundacao;
        Jogador[] jogadores = new Jogador[20];
        int max;
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor cheio
        /// </summary>
        /// <param name="nome">Nome da Equipa</param>
        /// <param name="fundacao">Data de Fundacao</param>
        /// <param name="jogador">Array de Jogadores</param>
        public Equipa(string nome, DateTime fundacao, Jogador[] jogador)
        {
            this.nome = nome;
            this.fundacao = fundacao;

            for(int i=0; i<this.jogadores.Length; i++)
            {
                this.jogadores[i] = jogador[i];
            }
        }


        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Equipa()
        {
            this.nome = "";
            this.fundacao = DateTime.Now; 
            
            for (int i = 0; i < this.jogadores.Length; i++)
            {
                this.jogadores[i] = null;
            }
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
        /// Manipula o atributo "jogador"
        /// </summary>
        public Jogador[] Jogador
        {
            get { return jogador[]; }
            set { jogador[] = value; }
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