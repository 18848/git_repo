/*
*	<copyright file="ProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/21/2020 6:48:39 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using ProjetoLP.Controllers;
using ProjetoLP.Models;

namespace ProjetoLP.View
{
    public interface IEquipaView
    {
        void SetNome();
        void SetFundacao();
        void SetJogadores();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 5/21/2020 6:48:39 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class EquipaView : IEquipaView
    {
        IEquipaController controller;
        CompeticaoController compController = new CompeticaoController();

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public EquipaView(IEquipaController c)
        {
            this.controller = c;
            this.controller.SetView(this);
        }

        #endregion

        #region Properties
        public void SetNome()
        {
            Console.Write("Nome: ");
            controller.SetNome(Console.ReadLine());
        }
        public void SetFundacao()
        {
            DateTime aux;
            Console.Write("Data de Fundação: ");
            if (DateTime.TryParse(Console.ReadLine(), out aux))
                controller.SetFundacao(aux);
        }
        
        public void SetJogadores()
        {
            Console.WriteLine("Insira Jogadores: ");
            compController.
        }

        #endregion


        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #endregion
    }
}
