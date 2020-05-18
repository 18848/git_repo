﻿using System;
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
		void SetModel(IArbitroModel aModel);

		//  Data Setters.
		void SetFormacao(DateTime f);
		void SetCategoria(CATEGORIA c);
		void SetAssociacao(ASSOCIACAO a);

		//  Data Getters.
		DateTime GetFormacao();
		CATEGORIA GetCategoria();
		ASSOCIACAO GetAssociacao();

		//  View Setter.
		void SetView(IArbitroView v);

		//  Data Update. (??)
		void AskCategoria();
		void AskAssociacao();
	}

	public class ArbitroController : IArbitroController
	{
		private IArbitroModel arbitro;
		private IArbitroView view;

		//public int Criar()
		//{

		//}

		#region Constructors
		/// <summary>
		/// MVC Constructor.
		/// </summary>
		/// <param name="model"> Model. </param>
		/// <param name="v"> View. </param>
		public ArbitroController(IArbitroModel model, IArbitroView v)
		{
			arbitro = model;
			view = v;
		}

		/// <summary>
		/// Default Constructor.
		/// </summary>
		public ArbitroController()
		{
			arbitro = new Arbitro();

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
			this.arbitro = aModel;
		}

        #region Set Data.
        public void SetFormacao(DateTime f)
		{
			arbitro.Formacao = f;
		}

		public void SetCategoria(CATEGORIA c)
		{
			arbitro.Categoria = c;
		}
		public void SetAssociacao(ASSOCIACAO a)
		{
			arbitro.Associacao = a;
		}
        #endregion
        
		#region Get Data.
        /// <summary>
		/// Encontra Data de Formacao.
		/// </summary>
		/// <returns> Data de Formacao. </returns>
		public DateTime GetFormacao()
		{
			return arbitro.Formacao;
		}

		/// <summary>
		/// Encontra Categoria.
		/// </summary>
		/// <returns> Categoria Atual. </returns>
		public CATEGORIA GetCategoria()
		{
			return arbitro.Categoria;
		}

		/// <summary>
		/// Encontra Associacao.
		/// </summary>
		/// <returns> Associacao Atual. </returns>
		public ASSOCIACAO GetAssociacao()
		{
			return arbitro.Associacao;
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
