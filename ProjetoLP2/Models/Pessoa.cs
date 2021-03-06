﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2.Models
{
    public interface IPessoa
    {
        string Nome { get; set; }
        string Nacionalidade { get; set; }
        DateTime DataNascimento { get; set; }
        float Altura { get; set; }
        float Peso { get; set; }
        bool Active { get; set; }
    }

    [Serializable]
    public class Pessoa : IPessoa
    {
        #region Member Values
        private string nome;
        private string nacionalidade;
        private DateTime dataNascimento;
        private float altura;
        private float peso;
        private bool active;
        #endregion

        #region Constructors
        /// <summary>
        /// The Default Constructor.
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

        #region Properties
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }
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
        public float Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }
        #endregion
    }
}
