/*
*	<copyright file="ProjetoLP.View.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>5/21/2020 7:18:15 PM</date>
*	<description></description>
**/
using System;
using ProjetoLP.Controllers;
using ProjetoLP.Models;
using System.Collections.Generic;

namespace ProjetoLP.View
{
    public interface ICompeticaoView
    {
        void SetEquipas();
        void SetArbitros();
        void SetInicio();
        void SetFim();

        void GetEquipas();
        void GetInicio();
        void GetFim();

        void ShowData();
    }

    /// <summary>
    /// Purpose:
    /// Created by: Ze
    /// Created on: 5/21/2020 7:18:15 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class CompeticaoView : ICompeticaoView
    {
        private readonly ICompeticaoController controller;

        #region Constructors
        /// <summary>
        /// View Constructor. Sets |Controller - View| relationship.
        /// </summary>
        /// <param name="cC"> Controller. </param>
        public CompeticaoView(ICompeticaoController cC)
        {
            controller = cC;
            controller.SetView(this);
        }
        #endregion

        #region Properties
        private bool SetEquipa(IEquipaView eV)
        {
            Console.WriteLine("Equipa Nova.");
            try
            {
                eV.SetFundacao();                
                eV.SetNome();                
                eV.SetJogadores();      
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true
        }

        public void SetEquipas()
        {
            IEquipaController eC = new EquipaController();
            IEquipaView eV = new EquipaView(eC);
            Console.WriteLine("Insira as equipas. ('.' para parar)")
            while(SetEquipa(eV)) { }
        }

        public void SetArbitros()
        {

        }

        public void SetInicio()
        {
            Console.Write("Data de Inicio: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime i))
                controller.SetInicio(i);
        }

        public void SetFim()
        {
            Console.Write("Data de Fim: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime f))
                controller.SetFim(f);
        }

        public void GetEquipas()
        {
            controller.GetEquipas().ForEach(delegate (Equipa equipa)
            {
                Console.WriteLine(equipa.Nome);
            });
        }

        public void GetInicio()
        {
            Console.WriteLine(controller.GetInicio().ToString());
        }

        public void GetFim()
        {
            Console.WriteLine(controller.GetFim().ToString());
        }

        public void ShowData()
        {
        }

        #endregion
    }
}
