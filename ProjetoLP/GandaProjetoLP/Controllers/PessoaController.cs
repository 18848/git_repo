/*
*	<copyright file="GandaProjetoLP.Controllers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/19/2020 10:26:24 AM</date>
*	<description></description>
**/
using System;
using ProjetoLP.View;
using ProjetoLP.Models;

namespace GandaProjetoLP.Controllers
{
    public interface IPessoaController
    {
        void SetView(IPessoaView v);

        void SetNome(string n);
        void SetNacionalidade(string n);
        void SetDataNascimento(DateTime d);
        void SetAltura(float h);

        string GetNome();
        string GetNacionalidade();
        DateTime GetDataNascimento();
        float GetAltura();
        float GetPeso();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/19/2020 10:26:24 AM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class PessoaController : IPessoaController
    {
        private IPessoaModel model;
        private IPessoaView view;

        #region Methods

        #region Constructors

        /// <summary>
        /// MVS Constructor.
        /// </summary>
        /// <param name="m"> Model. </param>
        /// <param name="v"> View. </param>
        public PessoaController(IPessoaModel m, IPessoaView v)
        {
            model = m;
            view = v;
        }

        public PessoaController()
        {
            model = new Pessoa();

            #region VIEW
            view.SetNome();
            view.SetDataNascimento();
            view.SetNacionalidade();
            view.SetAltura();
            view.SetPeso();

            view.ShowData();
            #endregion
        }

        #endregion

        #region Properties
        #region Setters
        public void SetNome(string n)
        {
            
        }
        public void SetNacionalidade(string n)
        {

        }
        public void SetDataNascimento(DateTime d)
        {

        }
        public void SetAltura(float a)
        {

        }
        public void SetPeso(float p)
        {

        }

        #endregion

        #region Getters

        public string GetNome()
        {
            return model.Nome;
        }
        public string GetNacionalidade()
        {
            return model.Nacionalidade;
        }
        public DateTime GetDataNascimento()
        {
            return model.DataNascimento;
        }
        public float GetAltura()
        {
            return model.Altura;
        }
        public float GetPeso()
        {
            return model.Peso;
        }

        #endregion

        #endregion



        #region Overrides
        #endregion

        #region OtherMethods

        #region View Control
        /// <summary>
        /// Set View Reference.
        /// </summary>
        /// <param name="v"> View. </param>
        public void SetView(IPessoaView v)
        {
            this.view = v;
        }

        #endregion
        #endregion

        #endregion
    }
}
