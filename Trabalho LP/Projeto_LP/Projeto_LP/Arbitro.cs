/*
*	<copyright file="Projeto_LP.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>4/20/2020 10:08:16 PM</date>
*	<description></description>
**/
using System;

namespace Projeto_LP
{
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 4/20/2020 10:08:16 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Arbitro : Pessoa
    {
        #region Attributes
        //probably a better way to place these variables
        //array or class maybe
        static DateTime formation;
        string academy;
        string rank;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Arbitro()
        {
            formation = new DateTime(1975, 1, 1);
            academy = "N/A"; 
            rank = "N/A";
        }

        /// <summary>
        /// Constructor by given data.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="a"></param>
        /// <param name="r"></param>
        public Arbitro(DateTime date, string a, string r)
        {
            formation =  date;
            academy = a;
            rank = r;
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
        //~Arbitro() { }
        #endregion

        #endregion
    }
}
