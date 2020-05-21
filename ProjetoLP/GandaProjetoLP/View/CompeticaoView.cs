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
        void SetEquipa();
        void SetInicio();
        void SetFim();

        void GetEquipas();
        void GetInicio();
        void GetFim();
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
        public void SetEquipa()
        {
            List<Equipa> equipas = new List<Equipa>();
            Equipa equipa = new Equipa();

            for(int i=0; i<10; i++)
            {
                Console.Write("Insira a " + (i+1).ToString() + "a Equipa: ");

                equipa.Nome = Console.ReadLine();
                equipas.Add(equipa);
            }

            controller.SetEquipas(equipas);
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

        #endregion
    }
}
