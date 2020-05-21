﻿/*
*	<copyright file="ProjetoLP.Controllers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/21/2020 6:55:01 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjetoLP.Models;
using ProjetoLP.View;


namespace ProjetoLP.Controllers
{
	public interface IArbitroController
	{
        #region Data Setters.
        void SetFormacao(DateTime f);
		void SetCategoria(CATEGORIA c);
		void SetAssociacao(ASSOCIACAO a);
		#endregion

		#region Data Getters.
		DateTime GetFormacao();
		CATEGORIA GetCategoria();
		ASSOCIACAO GetAssociacao();
		#endregion

		#region Data Update.
		void AskCategoria();
		void AskAssociacao();
		#endregion

		#region Data Delete.
		#endregion

		#region View Setter.
		void SetView(IArbitroView v);
		#endregion

		#region Model Setter.
		void SetModel(IArbitroModel aModel);
		#endregion
	}

	public class ArbitroController : IArbitroController
	{
		private IArbitroModel model;
		private IArbitroView view;

		#region Constructors
		/// <summary>
		/// MVC Constructor.
		/// </summary>
		/// <param name="m"> Model. </param>
		/// <param name="v"> View. </param>
		public ArbitroController(IArbitroModel m, IArbitroView v)
		{
			model = m;
			view = v;
		}

		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ArbitroController()
		{
            #region Model
            model = new Arbitro();
            #endregion

            #region VIEW
            view = new ArbitroView(this);

			view.SetFormacao();
			view.SetCategoria();
			view.SetAssociacao();

			view.ShowData();
			#endregion
		}
        #endregion

        #region Model Control

		/// <summary>
		/// Model.
		/// </summary>
		/// <param name="aModel"> Model. </param>
		public void SetModel(IArbitroModel aModel)
		{
			this.model = aModel;
		}

        #region Set Data.
        public void SetFormacao(DateTime f)
		{
			model.Formacao = f;
		}

		public void SetCategoria(CATEGORIA c)
		{
			model.Categoria = c;
		}
		public void SetAssociacao(ASSOCIACAO a)
		{
			model.Associacao = a;
		}
        #endregion
        
		#region Get Data.
        /// <summary>
		/// Encontra Data de Formacao.
		/// </summary>
		/// <returns> Data de Formacao. </returns>
		public DateTime GetFormacao()
		{
			return model.Formacao;
		}

		/// <summary>
		/// Encontra Categoria.
		/// </summary>
		/// <returns> Categoria Atual. </returns>
		public CATEGORIA GetCategoria()
		{
			return model.Categoria;
		}

		/// <summary>
		/// Encontra Associacao.
		/// </summary>
		/// <returns> Associacao Atual. </returns>
		public ASSOCIACAO GetAssociacao()
		{
			return model.Associacao;
		}

        #endregion

        #endregion

        #region View Control

        /// <summary>
        /// View Setter.
        /// </summary>
        /// <param name="v"></param>
        public void SetView(IArbitroView v)
		{
			this.view = v;
		}

		#region Data Update. (Through View, set above.)
		/// <summary>
		/// Atualiza Categoria.
		/// </summary>
		public void AskCategoria()
		{
			if (view != null)
				view.SetCategoria();
		}

		/// <summary>
		/// Atualiza Associacao.
		/// </summary>
		public void AskAssociacao()
		{
			if (view != null)
				view.SetAssociacao();
		}
		#endregion

		#endregion
	}
}
