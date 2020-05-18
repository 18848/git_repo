using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GandaProjetoLP.Models
{
    #region ENUMS
    #endregion

    class Competicao
    {
        #region MEMBER VARIABLES
        private Equipa[] equipa;
        private DateTime inicio;
        private DateTime fim;
        #endregion


        #region CONSTRUCTORS
        /// <summary>
        /// Construtor cheio
        /// </summary>
        /// <param name="inicio">Inicio da competicao</param>
        /// <param name="max"></param>
        public Competicao(DateTime inicio, int max)
        {
            this.inicio = inicio;
            equipa = new Equipa[max];
        }


        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Competicao()
        {
        }
        #endregion


        #region PROPERTIES
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
        #endregion
        /// <summary>
        /// Destructor -> Termina e apresenta a data do fim do campeonato.
        /// </summary>
        ~Competicao()
        {
            Fim = DateTime.Now;
            Console.WriteLine($"A competição terminou: {this.fim}");
        }
    }
}
