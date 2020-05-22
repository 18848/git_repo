using System;

namespace ProjetoLP.Models
{
    #region ENUMS
    #endregion

    public interface IPessoaModel
    {
        string Nome { get; set; }
        string Nacionalidade { get; set; }
        DateTime DataNascimento { get; set; }
        float Altura { get; set; }
        float Peso { get; set; }
    }

    public class Pessoa : IPessoaModel
    {
        #region MEMBER VARIABLES
        private string nome;
        private string nacionalidade;
        private DateTime dataNascimento;
        private float altura;
        private float peso;
        #endregion


        #region CONSTRUCTORS

        /// <summary>
        /// Construtor sem dados
        /// </summary>
        public Pessoa()
        {
            this.nome = "";
            this.nacionalidade = "";
            this.dataNascimento = DateTime.Now.Date;
            this.altura = 0;
            this.peso = 0;
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
        /// Manipula o atributo "nacionalidade"
        /// </summary>
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }


        /// <summary>
        /// Manipula o atributo "dataNascimento"
        /// </summary>
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    dataNascimento = value;
                }
            }
        }


        /// <summary>
        /// Manipula o atributo "altura"
        /// </summary>
        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        /// <summary>
        /// Manipula o atributo "peso"
        /// </summary>
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        #endregion


        #region FUNCTIONS
        #endregion


        #region OVERIDES
        #endregion
    }
}
