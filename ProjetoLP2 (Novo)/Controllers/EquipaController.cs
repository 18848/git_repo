﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;
using ProjetoLP2.Views;
using ProjetoLP2.Models.Guardar;

namespace ProjetoLP2.Controllers
{
    public interface IEquipaController
    {
        void GetAllEquipas();
        bool ProcurarEquipa(int id);
        void SetEquipa();
        void Add(IEquipa equipa);
        void GetEquipa();
        void Find(int id);
        void UpdateEquipa();
        void Update(IEquipa equipa);
        void DeleteEquipa(); 
        void Delete();
    }

    class EquipaController : IEquipaController
    {
        #region Member Values
        private IEquipa model;
        private IEquipaView view;
        private IGuardaEquipa list;
        #endregion

        #region Constructor
        public EquipaController()
        {
            list = new GuardaEquipa();
            list.Load("equipa.bin");
            view = new EquipaView(this);
        }
        #endregion

        #region View-Model-File
        public void SetView(IEquipaView v)
        {
            this.view = v;
        }

        public void SetModel(IGuardaEquipa m)
        {
            list = m;
        }

        public void SetModel(IEquipa m)
        {
            model = m;
        }

        public void Save()
        {
            list.Save("jogador.bin");
        }
        #endregion

        #region Functions
        public void GetAllEquipas()
        {
            int index = 0;
            if (view != null)
            {
                if (list != null)
                {
                    foreach (IEquipa i in list.GiveList())
                    {
                        index++;
                        if (i.Active)
                        {
                            view.ShowAll(i, index);
                        }
                    }
                }
            }
        }
        public bool ProcurarEquipa(int id)
        {
            IEquipa equipa;
            if (list != null)
            {
                equipa = list.Find(id);

                if (equipa != null)
                {
                    SetModel(equipa);
                    return true;
                }
            }
            return false;
        }
        public void SetEquipa()
        {
            if (view != null)
            {
                view.AddEquipa();
            }
        }
        public void Add(IEquipa equipa)
        {
            list.Add(equipa);
        }

        public void GetEquipa()
        {
            if (view != null)
            {
                view.GetEquipa();
            }
        }
        public void Find(int id)
        {
            if (list != null)
            {
                view.ShowOne(list.Find(id));
            }
        }
        public void UpdateEquipa()
        {
            if (view != null)
            {
                view.UpdateEquipa();
            }
        }
        public void Update(IEquipa equipa)
        {
            if (list != null)
            {
                model.UpdateEquipa(equipa);
            }
        }
        public void DeleteEquipa()
        {
            if (view != null)
            {
                view.DeleteEquipa();
            }
        }
        public void Delete()
        {
            if (list != null)
            {
                model.DeleteEquipa();
            }
        }
        #endregion
    }
}
