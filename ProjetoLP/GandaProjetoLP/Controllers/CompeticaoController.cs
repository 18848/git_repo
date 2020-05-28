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
        //void SetJogadores(List<Jogador> j);
        void SetInicio(DateTime i);
        void SetFim(DateTime f);
        #endregion

        #region Data Getters.
        // Present Equipa both individually and as a whole.
        List<IEquipaModel> GetEquipas();
        IEquipaModel GetEquipa(int id);
        
        // Present Arbitro both individually and as a whole.
        List<IArbitroModel> GetArbitros();
        IArbitroModel GetArbitro(int id);

        //// Present Jogador both individually and as a whole.
        List<IJogadorModel> GetJogadores();
        IJogadorModel GetJogador(int id);

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

        private IGuardarEquipa guardarEquipa;
        private IGuardarArbitro guardarArbitro;
        private IGuardarJogador guardarJogador;
        
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

            #region Model
            model = new Competicao();
            #endregion

            #region VIEW
            view = new CompeticaoView(this);

            view.SetEquipas();
            view.SetArbitros();
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
        public List<IEquipaModel> GetEquipas()
        {
            return guardarEquipa.GetEquipas();
        }
        /// <summary>
        /// Return Specified Equipa.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IEquipaModel GetEquipa(int id)
        {
            return guardarEquipa.GetEquipa(id);
        }
        #endregion

        #region Jogador(es)
        public List<IJogadorModel> GetJogadores()
        {
            return guardarJogador.GetJogadores();
        }

        public IJogadorModel GetJogador(int id)
        {
            return guardarJogador.GetJogador(id);
        }
        
        #endregion

        #region Arbitro(s)
        /// <summary>
        /// Return List of Arbitros.
        /// </summary>
        /// <returns></returns>
        public List<IArbitroModel> GetArbitros()
        {
            return guardarArbitro.GetArbitros();
        }
        /// <summary>
        /// Return Specified Arbitro.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IArbitroModel GetArbitro(int id)
        {
            return guardarArbitro.GetArbitro(id);
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
