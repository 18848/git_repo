using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP.Models;
using ProjetoLP.View;

namespace ProjetoLP.Controllers
{
    public interface IJogoController
    {
        #region Data Setters.
        void SetEquipaA(Equipa e);
        void SetEquipaB(Equipa e);
        void SetArbitros(List<Arbitro> a);
        #endregion

        #region Data Getters.
        Equipa GetEquipaA();
        Equipa GetEquipaB();
        List<Arbitro> GetArbitros();
        #endregion

        #region Data Update.
        #endregion

        #region Data Delete.
        #endregion

        #region View Setter.
        void SetView(IJogoView v);
        #endregion

        #region Model Setter.
        void SetModel(IJogoModel jModel);
        #endregion
    }

    /// <summary>
    /// Purpose:
    /// Created by: Ze
    /// Created on: 5/21/2020 6:55:01 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    class JogoController : IJogoController
    {
        private IJogoModel model;
        private IJogoView view;

        #region Constructors
        /// <summary>
        /// MVC Constructor.
        /// </summary>
        /// <param name="m"> Model. </param>
        /// <param name="v"> View. </param>
        public JogoController(IJogoModel m, IJogoView v)
        {
            model = m;
            view = v;
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public JogoController()
        {
            #region Model
            model = new Jogo();
            #endregion

            #region VIEW
            view = new JogoView(this);

            view.SetEquipaA();
            view.SetEquipaB();
            view.SetArbitros();

            view.ShowData();
            #endregion
        }
        #endregion

        #region Model Control

        /// <summary>
        /// Model.
        /// </summary>
        /// <param name="jModel"> Model. </param>
        public void SetModel(ICompeticaoModel jModel)
        {
            this.model = jModel;
        }

        #region Set Data.
        public void SetEquipaA(Equipa e)
        {
            model.EquipaA = e;
        }

        public void SetEquipaB(Equipa e)
        {
            model.EquipaA = e;
        }

        public void SetArbitros(List<Arbitro> a)
        {
            model.Arbitros = a;
        }
        #endregion

        #region Get Data.
        public Equipa GetEquipaA()
        {
            return model.EquipaA;
        }

        public Equipa GetEquipaB()
        {
            return model.EquipaB;
        }

        public List<Arbitro> GetArbitros()
        {
            return model.Arbitros;
        }

        #endregion

        #endregion

        #region View Control

        /// <summary>
        /// View Setter.
        /// </summary>
        /// <param name="v"></param>
        public void SetView(IJogoView v)
        {
            this.view = v;
        }

        #region Data Update.
        #endregion

        #endregion
    }
}
