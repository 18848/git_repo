/*
*	<copyright file="Projeto_LP.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>4/21/2020 2:46:55 PM</date>
*	<description></description>
**/
using System;

namespace Projeto_LP
{
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 4/21/2020 2:46:55 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Jogador : Pessoa
    {
        #region Attributes
        int number;
        string nickname;
        string role;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Jogador()
        {
            number = 0;
            nickname = "N/A";
            role = "N/A";
        }

        /// <summary>
        /// Construcor by given data.
        /// </summary>
        /// <param name="num"> Number. </param>
        /// <param name="name"> Nickname. </param>
        public Jogador(int num, string name, string r)
        {
            number = num;
            nickname = name;
            role = r;
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
        //~Jogador()
        //{
        //}
        #endregion

        #endregion
    }
}
