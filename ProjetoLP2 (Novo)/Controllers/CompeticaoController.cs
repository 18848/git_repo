using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;
using ProjetoLP2.Views;
using ProjetoLP2.Models.Guardar;

namespace ProjetoLP2.Controllers
{
    public interface ICompeticaoController
    {
        void SetView(ICompeticaoView v);
        void SetModel(IGuardaCompeticao m);
        void SetModelEquipa(IGuardaEquipa m);
        void SetModel(ICompeticao m);
        void GetAllCompeticoes();
        bool ProcurarCompeticao(int id);
        void SetCompeticao();
        void Add(ICompeticao competicao);
        void GetCompeticao();
        void Find(int id);
        void UpdateCompeticao();
        void Update(ICompeticao competicao);
        void DeleteCompeticao();
        void Delete();
        void UpdateEquipa();
        void UpdateEquipaModel(int id);
        void DeleteEquipa();
        void DeleteEquipaModel(int id);
        bool ProcurarEquipa(int id);
    }
    public class CompeticaoController : ICompeticaoController
    {

        #region Member Values
        private ICompeticao model;
        private ICompeticaoView view;
        private IGuardaCompeticao list;
        private IGuardaEquipa listEquipa;
        #endregion

        #region Constructor
        public CompeticaoController()
        {
            list = new GuardaCompeticao();
            list.Load("competicao.bin");
            listEquipa = new GuardaEquipa();
            listEquipa.Load("equipa.bin");

            view = new CompeticaoView(this);
        }
        #endregion

        #region View-Model-File
        public void SetView(ICompeticaoView v)
        {
            this.view = v;
        }

        public void SetModel(IGuardaCompeticao m)
        {
            list = m;
        }
        public void SetModelJogador(IGuardaEquipa m)
        {
            listEquipa = m;
        }
        public void SetModel(ICompeticao m)
        {
            model = m;
        }

        public void Save()
        {
            list.Save("equipa.bin");
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
                IEquipa equipa = new Equipa();
                List<IJogador> jogador = new List<IJogador>();
                List<IJogador> newJogador = new List<IJogador>();

                equipa = list.Find(id);
                jogador = listJogador.GiveList();

                foreach (int e in equipa.Jogadores)
                {
                    int index = 0;
                    foreach (IJogador j in jogador)
                    {
                        index++;
                        if (e == index)
                        {
                            newJogador.Add(j);
                            break;
                        }
                    }
                }

                view.ShowOne(equipa, newJogador);
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

        public void UpdateJogador()
        {
            if (view != null)
            {
                view.UpdateJogador();
            }
        }
        public void UpdateJogadorModel(int id)
        {
            if (list != null)
            {
                model.UpdateJogador(id);
            }
        }
        public bool ProcurarJogador(int id)
        {
            if (list != null)
            {
                return list.FindJogador(id);
            }
            return false;
        }

        public void DeleteJogador()
        {
            if (view != null)
            {
                view.DeleteJogador();
            }
        }
        public void DeleteJogadorModel(int id)
        {
            if (list != null)
            {
                model.DeleteJogador(id);
            }
        }
        #endregion
    }
}
