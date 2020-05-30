using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP.Models
{
    public interface IJogadorModel : IPessoaModel
    {
        string Alcunha { get; set; }
        int Numero { get; set; }
        POSICAO Posicao { get; set; }
        bool Active { get; set; }
        int Id { get; set; }
        string GetEquipa(int id);
    }

    public class Jogador : Pessoa, IJogadorModel, IPessoaModel
    {
        #region MEMBER VARIABLES

        private string alcunha;
        private int numero;
        private POSICAO posicao;
        private IGuardarEquipa e ;
        private IGuardarJogador j ;

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
            alcunha = "";
            numero = 0;
            posicao = POSICAO.ND;
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
            get;
            set;
        }
        public int Id { get; set; }
        
        public bool Active { get; set; }


        #endregion


        #region FUNCTIONS

        public string GetEquipa(int id)
        {
            return e.GetEquipa(id).Nome;
        }

        #endregion


        #region OVERIDES
        public override string ToString()
        {
            string jogador = string.Format("\tNome: {0}\n\tAlcunha: {1}\n\tNúmero: {2}\n\tNacionalidade: {3}\n\tIdade: {4}\n\tAltura: {5}\n\tPeso: {6}" +
                "\n\tEquipa: {7}\n\tPosição: {8} ", Nome, Alcunha, Numero, Nacionalidade, (DateTime.Now.Year - DataNascimento.Year).ToString(), 
                Altura, Peso, GetEquipa(Id), Posicao);
            return jogador;
        }
        #endregion
    }
}
