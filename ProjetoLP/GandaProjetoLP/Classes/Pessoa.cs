using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GandaProjetoLP.Classes
{
    class Pessoa
    {
        #region ENUMS
        #endregion


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


        #region PROPERTIES
        /// <summary>
        /// Manipula o atributo "nome"
        /// string nome;
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Manipula o atributo "nacionalidade"
        /// string nome;
        /// </summary>
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }


        /// <summary>
        /// Data de Nascimento
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
        #endregion


        #region FUNCTIONS
        #endregion
    }
}
