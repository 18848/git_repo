/*
*	<copyright file="ProjetoLP.Controllers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Ze</author>
*   <date>5/21/2020 6:55:01 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using ProjetoLP.Models;
using ProjetoLP.View;

namespace ProjetoLP.Controllers
{
    public interface ICompeticaoController
    {
        #region Data Setters.
        void SetEquipas(List<Equipa> e);
        void SetArbitros(List<Arbitro> a);
        void SetJogadores(List<Jogador> j);
        void SetInicio(DateTime i);
        void SetFim(DateTime f);
        #endregion

        #region Data Getters.
        // Present Equipa both individually and as a whole.
        List<Equipa> GetEquipas();
        Equipa GetEquipa(string n);
        
        // Present Arbitro both individually and as a whole.
        List<Arbitro> GetArbitros();
        Arbitro GetArbitro(int id);

        //// Present Jogador both individually and as a whole.
        List<Jogador> GetJogadores();
        Jogador GetJogador(string n);

        //
        DateTime GetInicio();
        DateTime GetFim();
        #endregion

        #region Data Update.
        /*void AskCategoria();
        void AskAssociacao();*/
        #endregion

        #region Data Delete.
        #endregion

        #region View Setter.
        void SetView(ICompeticaoView v);
        #endregion

        #region Model Setter.
        void SetModel(ICompeticaoModel cModel);
        #endregion
    }


    /// <summary>
    /// Purpose:
    /// Created by: Ze
    /// Created on: 5/21/2020 6:55:01 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class CompeticaoController : ICompeticaoController
    {
        private ICompeticaoModel model;
        private ICompeticaoView view;

        private EquipaController equipaController;
        private ArbitroController arbitroController;
        private JogadorController jogadorController;

        #region Constructors
        /// <summary>
        /// MVC Constructor.
        /// </summary>
        /// <param name="m"> Model. </param>
        /// <param name="v"> View. </param>
        public CompeticaoController(ICompeticaoModel m, ICompeticaoView v)
        {
            model = m;
            view = v;
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CompeticaoController()
        {
            equipaController = new EquipaController(this);
            arbitroController = new ArbitroController();


            #region Model
            model = new Competicao();
            #endregion

            #region VIEW
            view = new CompeticaoView(this);

            view.SetEquipas();
            view.SetArbitros();
            view.SetJogadores();
            view.SetInicio();
            view.SetFim();

            view.ShowData();
            #endregion
        }
        #endregion

        #region Model Control

        /// <summary>
        /// Model.
        /// </summary>
        /// <param name="cModel"> Model. </param>
        public void SetModel(ICompeticaoModel cModel)
        {
            model = cModel;
        }

        #region Set Data.
        public void SetEquipas(List<Equipa> e)
        {
            model.Equipas = e;
        }
        public void SetArbitros(List<Arbitro> a)
        {
            model.Arbitros = a;
        }
        public void setJogadores(int equipaID, List<Jogador> j)
        {
            model.Equipas[equipaID].Jogadores = j;
        }

        public void SetInicio(DateTime i)
        {
            model.Inicio = i;
        }

        public void SetFim(DateTime f)
        {
            model.Fim = f;
        }
        #endregion

        #region Get Data.
        #region Equipa(s)
        /// <summary>
        /// Return List of Equipas.
        /// </summary>
        /// <returns></returns>
        public List<Equipa> GetEquipas()
        {
            return model.Equipas;
        }
        /// <summary>
        /// Return Specified Equipa.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Equipa GetEquipa(string n)
        {
            foreach (Equipa e in model.Equipas)
                if (e.Nome == n) return e;
            return null;
        }
        #endregion

        //#region Jogador(es)
        ///// <summary>
        ///// Return List of Jogadores in Competicao.
        ///// </summary>
        ///// <returns></returns>
        //public List<Jogador> GetJogadores()
        //{
        //    return model.Jogadores;
        //}
        ///// <summary>
        ///// Return Specified Jogador.
        ///// </summary>
        ///// <param name="n"></param>
        ///// <returns></returns>
        //public Jogador GetJogador(string n)
        //{
        //    foreach (Jogador j in model.Jogadores)
        //        if (j.Nome == n) return j;
        //    return null;
        //}
        //#endregion

        #region Arbitro(s)
        /// <summary>
        /// Return List of Arbitros.
        /// </summary>
        /// <returns></returns>
        public List<Arbitro> GetArbitros()
        {
            return model.Arbitros;
        }
        /// <summary>
        /// Return Specified Arbitro.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Arbitro GetArbitro(int id)
        {
            foreach (Arbitro a in model.Arbitros)
                if (a.Id == id) return a;
            return null;
        }
        #endregion

        /// <summary>
        /// Return Data de Inicio.
        /// </summary>
        /// <returns></returns>
        public DateTime GetInicio()
        {
            return model.Inicio;
        }
        /// <summary>
        /// Return Data de Fim.
        /// </summary>
        /// <returns></returns>
        public DateTime GetFim()
        {
            return model.Fim;
        }

        #endregion

        

        #endregion

        #region View Control

        /// <summary>
        /// View Setter.
        /// </summary>
        /// <param name="v"></param>
        public void SetView(ICompeticaoView v)
        {
            this.view = v;
        }

        #region Data Update.
        #endregion

        #endregion
    }
}
