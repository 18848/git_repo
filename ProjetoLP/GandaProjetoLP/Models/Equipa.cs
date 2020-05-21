using System;
using System.Collections.Generic;

namespace ProjetoLP.Models
{
    public interface IEquipaModel
    {
        string Nome { get; set; }
        DateTime Fundacao { get; set; }
        List<Jogador> Jogadores { get; set; }
    }

    public class Equipa : IEquipaModel
    {
        #region MEMBER VARIABLES
        private string nome;
        private DateTime fundacao;
        private List<Jogador> jogadores;
        #endregion


        #region CONSTRUCTORS
        ///
        public Equipa(string n, DateTime f, List<Jogador> j)
        {
            this.nome = n;
            this.fundacao = f;
            foreach(Jogador jog in j)
                this.jogadores.Add(jog);
        }


        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Equipa()
        {
            this.nome = "";
            this.fundacao = DateTime.Now;
            jogadores = null;
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
        public List<Jogador> Jogadores
        {
            get { return this.jogadores; }
            set { this.jogadores = value; }
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERRIDES
        #endregion
    }
}