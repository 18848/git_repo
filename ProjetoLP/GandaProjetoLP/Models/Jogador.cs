using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP.Models
{
    public interface IJogadorModel
    {
        string Alcunha { get; set; }
        int Numero { get; set; }
        POSICAO Posicao { get; set; }
        int Id { get; set; }
        bool Active { get; set; }
    }

    public class Jogador : Pessoa, IJogadorModel, IPessoaModel
    {
        #region MEMBER VARIABLES
        private string alcunha;
        private int numero;
        private POSICAO posicao;
        private int id;
        #endregion


        #region CONSTRUCTORS

        public Jogador(string a, int n, POSICAO p, 
            string nome, string nac, DateTime d, float altura, float peso) 
            : base(nome, nac, d ,altura, peso)
        {
            alcunha = a;
            numero = n;
            posicao = p;
        }

        /// <summary>
        /// Construtor vazio
        /// </summary>
        public Jogador() : base()
        {
            this.alcunha = "";
            this.numero = 0;
            this.posicao = POSICAO.ND;
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
            set
            {
                if ((value > 0) && (value < 99))
                    numero = value;
            }
        }
 

        /// <summary>
        /// Manipula o atributo "posicao"
        /// </summary>
        public POSICAO Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        public int Id
        {
            get; set;
        }
        
        public bool Active { get; set; }

        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
