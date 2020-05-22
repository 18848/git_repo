using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoLP.Models;
using ProjetoLP.View;

namespace ProjetoLP.Models
{
    public interface ICompeticaoModel
    {
        List<Equipa> Equipas { get; set; }
        List<Arbitro> Arbitros { get; set; }
        List<Jogador> Jogadores { get; set; }
        DateTime Inicio { get; set; }
        DateTime Fim { get; set; }
    }

    class Competicao : ICompeticaoModel
    {
        #region MEMBER VARIABLES
        private List<Equipa> equipas;
        private List<Arbitro> arbitros;
        private List<Jogador> jogadores;
        private DateTime inicio;
        private DateTime fim;
        #endregion


        #region CONSTRUCTORS
        
        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Competicao()
        {
            this.inicio = DateTime.Now;
            equipas = new List<Equipa>();
            arbitros = new List<Arbitro>();
        }
        #endregion


        #region PROPERTIES
        
        public List<Equipa> Equipas
        {
            get { return equipas; }
            set { equipas = value; }
        }
        public List<Arbitro> Arbitros
        {
            get;
            set;
        }
        public List<Jogador> Jogadores
        {
            get;
            set;
        }

        /// <summary>
        /// Manipula o atributo "inicio"
        /// </summary>
        public DateTime Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        /// <summary>
        /// Manipula o atributo "fim"
        /// </summary>
        public DateTime Fim
        {
            get { return fim; }
            set { fim = value; }
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        /// <summary>
        /// Destructor -> Termina e apresenta a data do fim do campeonato.
        /// </summary>
        ~Competicao()
        {
            Fim = DateTime.Now;
            Console.WriteLine($"A competição terminou: {this.fim}");
        }
        #endregion
    }
}
