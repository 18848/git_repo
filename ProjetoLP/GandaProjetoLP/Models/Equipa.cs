using System;

namespace ProjetoLP.Models
{
    public interface IEquipaModel
    {
        string Nome { get; set; }
        DateTime Fundacao { get; set; }
        List<Jogador> Jogadores { get; set; }
    }

    public class Equipa
    {
        #region MEMBER VARIABLES
        private string nome;
        private DateTime fundacao;
        private List<Jogador> jogadores;
        const int max = 100; //<<<<<<<<<<< que achas?
        int totJogadores;
        #endregion


        #region CONSTRUCTORS
        ///
        public Equipa(string n, DateTime f, List<Jogador> j)
        {
            this.nome = n;
            this.fundacao = f;
            this.jogadores.
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
            get { return this.jogadores; }
            set { this.jogadores = value; }
        }
        #endregion


        #region FUNCTIONS
        /// <summary>
        /// Registar um jogador novo na equipa
        /// </summary>
        /// <param name="jogador">Novo jogador.</param>
        /// <returns></returns>
        public int InserirJogador(Jogador jogador)
        {
            if (this.totJogadores >= max) return 0;

            jogadores[this.totJogadores++] = jogador;
            return 1;
        }
        #endregion


        #region OVERRIDES
        #endregion
    }
}