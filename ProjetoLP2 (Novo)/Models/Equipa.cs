using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2.Models
{
    public interface IEquipa
    {
        string Nome { get; set; }
        DateTime Fundacao { get; set; }
        List<Jogador> Jogadores { get; set; }
        int Id { get; set; }
        bool Active { get; set; }

        void UpdateEquipa(IEquipa equipa);
        void DeleteEquipa();
    }

    public class Equipa : IEquipa
    {
        #region MEMBER VARIABLES
        private string nome;
        private DateTime fundacao;
        private List<Jogador> jogadores;
        private bool id;
        #endregion


        #region CONSTRUCTORS

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Equipa()
        {
            Nome = "";
            Fundacao = DateTime.Now;
            Jogadores = null;
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
        /// Manipula o atributo "jogadores"
        /// </summary>
        public List<Jogador> Jogadores
        {
            get { return jogadores; }
            set { jogadores = value; }
        }

        public int Id
        {
            get;
            set;
        }

        public bool Active
        {
            get;
            set;
        }

        #endregion


        #region FUNCTIONS


        public void UpdateEquipa(IEquipa equipa)
        {
            Nome = equipa.Nome;
            Fundacao = equipa.Fundacao;
            Jogadores = equipa.Jogadores;
            Id = equipa.Id;
        }

        public void DeleteEquipa()
        {

        }

        #endregion
    }
}
