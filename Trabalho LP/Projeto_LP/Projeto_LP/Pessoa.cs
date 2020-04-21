/*
*	<copyright file="Projeto_LP.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Andre</author>
*   <date>4/20/2020 11:05:17 PM</date>
*	<description></description>
**/
using System;

namespace Projeto_LP
{
    /// <summary>
    /// Purpose:
    /// Created by: Andre
    /// Created on: 4/20/2020 11:05:17 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Pessoa
    {
        #region Attributes
        DateTime birth;
        int height;
        int weight;
        string name;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Pessoa()
        {
            birth = new DateTime(2000, 1, 1);
            height = -1;
            weight = -1;
            name = "N/A";
        }

        /// <summary>
        /// Constructor by given data.
        /// </summary>
        /// <param name="n">name</param>
        /// <param name="h">height</param>
        /// <param name="w">weight</param>
        /// <param name="b">birth</param>
        public Pessoa(string n, int h, int w, DateTime b) 
        {
            birth = b;
            height = h;
            weight = w;
            name = n;
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
        //~Pessoa()
        //{
        //}
        #endregion

        #endregion
    }
}
