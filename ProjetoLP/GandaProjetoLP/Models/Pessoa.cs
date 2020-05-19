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
        /// Construtor com dados vindos do exterior
        /// </summary>
        /// <param name="nome">Nome da Pessoa</param>
        /// <param name="nacionalidade">Nacionalidade da Pessoa</param>
        /// <param name="dataNascimento">DataNascimento da Pessoa</param>
        /// <param name="altura">Altura da Pessoa</param>
        /// <param name="peso">Peso da Pessoa</param>
        public Pessoa(string nome, string nacionalidade, DateTime dataNascimento, float altura, float peso)
        {
            this.nome = nome;
            this.nacionalidade = nacionalidade;
            this.dataNascimento = dataNascimento;
            this.altura = altura;
            this.peso = peso;
        }


        /// <summary>
        /// Construtor sem dados
        /// </summary>
        public Pessoa()
        {
            this.nome = "";
            this.nacionalidade = "";
            this.dataNascimento = DateTime.Now;
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
