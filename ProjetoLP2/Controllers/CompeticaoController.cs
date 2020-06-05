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
        void GetCompeticaoJogo();
        void Add(ICompeticao competicao);
        void GetCompeticao();
        void Find(int id);
        void FindJogo(int id);
        void UpdateCompeticao();
        void Update(ICompeticao competicao);
        void DeleteCompeticao();
        void Delete();
        void UpdateEquipa();
        void UpdateEquipaModel(int id);
        void DeleteEquipa();
        void DeleteEquipaModel(int id);
        bool ProcurarEquipa(int id);
        void DeleteJogo();
        void DeleteJogoModel(int id);
        bool ProcurarJogo(int id);
    }
    public class CompeticaoController : ICompeticaoController
    {
        #region Member Values
        private ICompeticao model;
        private ICompeticaoView view;
        private IGuardaCompeticao list;
        private IGuardaEquipa listEquipa;
        private IGuardaJogo listJogo;
        #endregion

        #region Constructor
        public CompeticaoController()
        {
            list = new GuardaCompeticao();
            list.Load("competicao.bin");
            listEquipa = new GuardaEquipa();
            listEquipa.Load("equipa.bin");
            listJogo = new GuardaJogo();
            listJogo.Load("jogo.bin");

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
        public void SetModelEquipa(IGuardaEquipa m)
        {
            listEquipa = m;
        }
        public void SetModel(ICompeticao m)
        {
            model = m;
        }

        public void Save()
        {
            list.Save("competicao.bin");
        }
        #endregion

        #region Functions
        public void GetAllCompeticoes()
        {
            int index = 0;
            if (view != null)
            {
                if (list != null)
                {
                    foreach (ICompeticao i in list.GiveList())
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
        public bool ProcurarCompeticao(int id)
        {
            ICompeticao competicao;
            if (list != null)
            {
                competicao = list.Find(id);

                if (competicao != null)
                {
                    SetModel(competicao);
                    return true;
                }
            }
            return false;
        }
        public void SetCompeticao()
        {
            if (view != null)
            {
                view.AddCompeticao();
            }
        }
        public void Add(ICompeticao competicao)
        {
            list.Add(competicao);
        }

        public void GetCompeticao()
        {
            if (view != null)
            {
                view.GetCompeticao();
            }
        }

        public void GetCompeticaoJogo()
        {
            if (view != null)
            {
                view.GetCompeticaoJogo();
            }
        }

        public void Find(int id)
        {
            if (list != null)
            {
                ICompeticao competicao = new Competicao();
                List<IEquipa> equipa = new List<IEquipa>();
                List<IEquipa> newEquipa = new List<IEquipa>();

                competicao = list.Find(id);
                equipa = listEquipa.GiveList();

                foreach (int c in competicao.Equipas)
                {
                    int index = 0;
                    foreach (IEquipa i in equipa)
                    {
                        index++;
                        if (c == index)
                        {
                            newEquipa.Add(i);
                            break;
                        }
                    }
                }

                view.ShowOne(competicao, newEquipa);
            }
        }
        public void FindJogo(int id)
        {
            if (list != null)
            {
                ICompeticao competicao = new Competicao();
                List<IJogo> jogo = new List<IJogo>();
                List<IJogo> newJogo = new List<IJogo>();

                competicao = list.Find(id);
                jogo = listJogo.GiveList();

                foreach (int c in competicao.Jogos)
                {
                    int index = 0;
                    foreach (IJogo i in jogo)
                    {
                        index++;
                        if (c == index)
                        {
                            newJogo.Add(i);
                            break;
                        }
                    }
                }

                view.ShowOneJogo(competicao, newJogo);
            }
        }
        public void UpdateCompeticao()
        {
            if (view != null)
            {
                view.UpdateCompeticao();
            }
        }
        public void Update(ICompeticao competicao)
        {
            if (list != null)
            {
                model.UpdateCompeticao(competicao);
            }
        }
        public void DeleteCompeticao()
        {
            if (view != null)
            {
                view.DeleteCompeticao();
            }
        }
        public void Delete()
        {
            if (list != null)
            {
                model.DeleteCompeticao();
            }
        }

        public void UpdateEquipa()
        {
            if (view != null)
            {
                view.UpdateEquipa();
            }
        }
        public void UpdateEquipaModel(int id)
        {
            if (list != null)
            {
                model.UpdateEquipa(id);
            }
        }
        public bool ProcurarEquipa(int id)
        {
            if (list != null)
            {
                return list.FindEquipa(id);
            }
            return false;
        }

        public void DeleteEquipa()
        {
            if (view != null)
            {
                view.DeleteEquipa();
            }
        }
        public void DeleteEquipaModel(int id)
        {
            if (list != null)
            {
                model.DeleteEquipa(id);
            }
        }
        public bool ProcurarJogo(int id)
        {
            if (list != null)
            {
                return list.FindJogo(id);
            }
            return false;
        }

        public void DeleteJogo()
        {
            if (view != null)
            {
                view.DeleteJogo();
            }
        }
        public void DeleteJogoModel(int id)
        {
            if (list != null)
            {
                model.DeleteJogo(id);
            }
        }
        #endregion
    }
}
