/*
*	<copyright file="Projeto_LP.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>4/21/2020 3:00:44 PM</date>
*	<description></description>
**/
using System;

namespace Projeto_LP
{
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 4/21/2020 3:00:44 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Equipa : Jogadores
    {
        #region Attributes
        string name;
        string rank;
        int points;
        DateTime foundation;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Equipa()
        {
            name = "N/A";
            rank = "N/A";
            points = 0;
            foundation = new DateTime(1920, 1 ,1);
        }


        public Equipa(string n, string r, int p, DateTime f)
        {
            name = n;
            rank = r;
            points = p;
            foundation = f;
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
        //~Equipa()
        //{
        //}
        #endregion

        #endregion
    }
}
