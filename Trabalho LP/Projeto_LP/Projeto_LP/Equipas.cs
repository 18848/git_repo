/*
*	<copyright file="Projeto_LP.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>4/21/2020 3:06:32 PM</date>
*	<description></description>
**/
using System;

namespace Projeto_LP
{
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 4/21/2020 3:06:32 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Equipas : Equipa
    {
        #region Attributes
        Equipa[] team;
        string league;
        string lastChampeon;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Equipas()
        {
            league = "N/A";
            lastChampeon = "N/A";
            team = new Equipa[1];
        }

        /// <summary>
        /// Constructor by given data.
        /// </summary>
        /// <param name="s"> 0->league; 1->lastChampeon; 2->size of array; </param>
        /// <param name="t"> array of Equipa </param>
        public Equipas(string[] s, Equipa[] t)
        {
            league = s[0];
            lastChampeon = s[1];
            //Attempt to convert string to int
            //If it works, assign value to size; Else, assign 1;
            int size = (int.TryParse(s[2], out size) ? size : 1);
            team = new Equipa[size];
            for(int i=0; i<size; i++)
            {
                team[i] = t[i];
            }
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
        //~Equipas()
        //{
        //}
        #endregion

        #endregion
    }
}
