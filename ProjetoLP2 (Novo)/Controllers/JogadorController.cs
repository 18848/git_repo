using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models.Guardar;
using ProjetoLP2.Models;
using ProjetoLP2.Views;

namespace ProjetoLP2.Controllers
{
    public interface IJogadorController
    {
        void SetView(IJogadorView v);
        void SetModel(IGuardaJogador m);
        void SetModel(IJogador m);
        void GetAllJogadores();
        bool ProcurarJogador(int id);
        void SetJogador();
        void Add(IJogador jogador);
        void GetJogador();
        void Find(int id);
        void UpdateJogador();
        void Update(IJogador jogador);
        void DeleteJogador();
        void Delete();
    }
    
    public class JogadorController : IJogadorController
    {
        #region Member Values
        private IJogador model;
        private IJogadorView view;
        private IGuardaJogador list;
        #endregion

        #region Constructor
        public JogadorController()
        {
            list = new GuardaJogador();
            list.Load("jogador.bin");
            view = new JogadorView(this);
        }
        #endregion

        #region View-Model-File
        public void SetView(IJogadorView v)
        {
            this.view = v;
        }

        public void SetModel(IGuardaJogador m)
        {
            list = m;
        }

        public void SetModel(IJogador m)
        {
            model = m;
        }

        public void Save()
        {
            list.Save("jogador.bin");
        }
        #endregion

        #region Functions
        public void GetAllJogadores()
        {
            int index = 0;
            if (view != null)
            {
                if (list != null)
                {
                    foreach (IJogador i in list.GiveList())
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
        public bool ProcurarJogador(int id)
        {
            IJogador jogador;
            if (list != null)
            {
                jogador = list.Find(id);

                if (jogador != null)
                {
                    SetModel(jogador);
                    return true;
                }
            }
            return false;
        }
        public void SetJogador()
        {
            if (view != null)
            {
                view.AddJogador();
            }
        }
        public void Add(IJogador jogador)
        {
            list.Add(jogador);
        }

        public void GetJogador()
        {
            if (view != null)
            {
                view.GetJogador();
            }
        }
        public void Find(int id)
        {
            if (list != null)
            {
                view.ShowOne(list.Find(id));
            }
        }
        public void UpdateJogador()
        {
            if (view != null)
            {
                view.UpdateJogador();
            }
        }
        public void Update(IJogador jogador)
        {
            if (list != null)
            {
                model.UpdatePessoa(jogador);
            }
        }
        public void DeleteJogador()
        {
            if (view != null)
            {
                view.DeleteJogador();
            }
        }
        public void Delete()
        {
            if (list != null)
            {
                model.DeleteJogador();
            }
        }
        #endregion
    }
}
