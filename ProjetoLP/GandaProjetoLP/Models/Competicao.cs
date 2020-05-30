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
        string Name { get; set; }
        DateTime Inicio { get; set; }
        DateTime Fim { get; set; }
        int Id { get; set; }
        bool Active { get; set; }
    }

    class Competicao : ICompeticaoModel
    {
        #region MEMBER VARIABLES
        private string name;
        private DateTime inicio;
        private DateTime fim;
        #endregion


        #region CONSTRUCTORS
        
        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Competicao()
        {
            inicio = DateTime.Now;
        }
        #endregion


        #region PROPERTIES

        public string Name
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

        /// <summary>
        /// Manipula o atributo "totalArbitros"
        /// </summary>
        public int TotalArbitros
        {
            get; set;
        }
        public int Id { get; set; }
        public bool Active { get; set; }
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
