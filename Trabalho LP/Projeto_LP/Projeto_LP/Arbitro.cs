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
        int gamesTotal;
        int gamesSeason;
        int gamesRound;
        int cardsYellow;
        int cardsRed;
        double salary;
        static DateTime formation;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Arbitro()
        {
            gamesTotal = 0;
            gamesSeason = 0;
            gamesRound = 0;
            cardsYellow = 0;
            cardsRed = 0;
            salary = 0;
            formation = new DateTime(1975, 1, 1);
        }

        /// <summary>
        /// Constructor by given data.
        /// </summary>
        /// <param name="games"> 0->total; 1->season; 2->round </param>
        /// <param name="cards"> 0->yellow; 1-> red; </param>
        /// <param name="s"> salary </param>
        /// <param name="d"> formation date </param>
        public Arbitro(int[] games, int[] cards, double s, DateTime d)
        {
            gamesTotal = games[0];
            gamesSeason = games[1];
            gamesRound = games[2];
            cardsYellow = cards[0];
            cardsRed = cards[1];
            salary = s;
            formation =  d;
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
