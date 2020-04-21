﻿/*
*	<copyright file="Projeto_LP.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>4/20/2020 10:06:20 PM</date>
*	<description></description>
**/
using System;

namespace Projeto_LP
{
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 4/20/2020 10:06:20 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Arbitros : Arbitro
    {
        #region Attributes
        Arbitro[] arbitro;
        string academy;
        string rank;
        string league;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Arbitros()
        {
            arbitro = new Arbitro[1];
            academy = "N/A";
            league = "N/A";
            rank = "N/A";
        }

        /// <summary>
        /// Constructor with given data.
        /// </summary>
        /// <param name="s"> 0->academy; 1->league; 2->rank; 3->size of array; </param>
        public Arbitros(string[] s)
        {
            academy = s[0];
            league = s[1];
            rank = s[2];
            //Attempt to convert string to int
            //If it works, assign value to size; Else, assign 1;
            int size = ( int.TryParse(s[3], out size) ? size : 1 );
            arbitro = new Arbitro[ size ];
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
        ~Arbitros()
        {
        }
        #endregion

        #endregion
    }
}
