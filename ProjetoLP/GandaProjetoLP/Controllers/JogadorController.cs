/*
*	<copyright file="GandaProjetoLP.Controllers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/20/2020 6:27:26 PM</date>
*	<description></description>
**/
using ProjetoLP.View;
using ProjetoLP.Models;
using System;

namespace ProjetoLP.Controllers
{
    public interface IJogadorController
    {
        void SetView(IJogadorView v);

        //Set Data
        void SetAlcunha(string a);
        void SetNumero(int n);
        void SetPosicao(POSICAO p);

        string GetAlcunha();
        int GetNumero();
        POSICAO GetPosicao();

        void AskAlcunha();
        void AskNumero();
        void AskPosicao();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/20/2020 6:27:26 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class JogadorController : IJogadorController
    {
        IJogadorModel model;
        IJogadorView view;

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public JogadorController()
        {
            model = new Jogador();

            #region VIEW

            view = new JogadorView(this);

            view.SetAlcunha();
            view.SetNumero();
            view.SetPosicao();

            view.ShowData();

            #endregion
        }

        #endregion

        #region Properties

        #region Setters 
        public void SetAlcunha(string a)
        {
            model.Alcunha = a;
        }
        public void SetNumero(int n)
        {
            model.Numero = n;
        }
        public void SetPosicao(POSICAO p)
        {
            model.Posicao = p;
        }
        #endregion

        #region Getters
        public string GetAlcunha()
        {
            return model.Alcunha;
        }
        public int GetNumero()
        {
            return model.Numero;
        }
        public POSICAO GetPosicao()
        {
            return model.Posicao;
        }
        #endregion

        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        public void SetView(IJogadorView v)
        {
            this.view = v;
        }


        public void AskAlcunha()
        {
            if (view != null)
                view.SetAlcunha();
        }
        public void AskNumero()
        {
            if (view != null)
                view.SetNumero();
        }
        public void AskPosicao()
        {
            if (view != null)
                view.SetPosicao();
        }

        #endregion

        #endregion
    }
}
