/*
*	<copyright file="ProjetoLP.Controllers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/20/2020 6:27:26 PM</date>
*	<description></description>
**/
using System.Collections.Generic;
using ProjetoLP.View;
using ProjetoLP.Models;

namespace ProjetoLP.Controllers
{
    public interface IJogadorController
    {
        #region Data Setters.
        void SetAlcunha(string a);
        void SetNumero(int n);
        void SetPosicao(POSICAO p);
        #endregion

        #region Data Getters.
        string GetAlcunha();
        int GetNumero();
        POSICAO GetPosicao();
        #endregion

        //#region Data Update.
        //void AskAlcunha();
        //void AskNumero();
        //void AskPosicao();
        //#endregion

        #region File Management.
        bool AddJogador();
        bool SaveJogadores();
        bool LoadJogadores();
        bool RemoveJogador(int id);
        List<IJogadorModel> GetJogadores();
        #endregion

        #region View Setter.
        void SetView(IJogadorView v);
        #endregion
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/20/2020 6:27:26 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class JogadorController : PessoaController, IJogadorController, IPessoaController
    {
        private IJogadorModel model;
        private IJogadorView view;
        private string filePath = "../Files/Jogador.dat";

        private GuardarJogador ficheiro = new GuardarJogador();

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

            //view.ShowData();

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

        #region File Management.
        public bool AddJogador()
        {
            return ficheiro.AddJogador(model);
        }
        public bool SaveJogadores()
        {
            return ficheiro.SaveJogadores(@filePath);
        }
        public bool LoadJogadores()
        {
            return ficheiro.LoadJogadores(@filePath);
        }
        public bool RemoveJogador(int id)
        {
            return ficheiro.RemoveJogador(id);
        }
        public List<IJogadorModel> GetJogadores()
        {
            return ficheiro.GetJogadores();
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


        //public void AskAlcunha()
        //{
        //    if (view != null)
        //        view.SetAlcunha();
        //    view.Set
        //}
        //public void AskNumero()
        //{
        //    if (view != null)
        //        view.SetNumero();
        //}
        //public void AskPosicao()
        //{
        //    if (view != null)
        //        view.SetPosicao();
        //}

        #endregion

        #endregion
    }
}
