/*
*	<copyright file="Projeto_LP.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>4/21/2020 2:53:33 PM</date>
*	<description></description>
**/
using System;

namespace Projeto_LP
{
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 4/21/2020 2:53:33 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Jogadores : Jogador
    {
        #region Attributes
        Jogador[] player;
        string role;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Jogadores()
        {
            role = "N/A";
            player = new Jogador[1];
        }

        /// <summary>
        /// Constructor by given data.
        /// </summary>
        /// <param name="s"> 0->role; 1->size; </param>
        public Jogadores(string[] s)
        {
            role = s[0];
            //Attempt to convert string to int
            //If it works, assign value to size; Else, assign 1;
            int size = (int.TryParse(s[2], out size) ? size : 1);
            player = new Jogador[size];
        }

        #endregion

        #region Properties
        #endregion



        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        //~Jogadores()
        //{
        //}
        #endregion

        #endregion
    }
}
