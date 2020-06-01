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
    public interface IJogoController
    {
        void SetView(IJogoView v);
        void SetListModel(IGuardaJogo m);
        void SetModel(IJogo m);
        void GetAllJogos();
        List<IArbitro> GetArbitros(List<int> id);
        List<IEquipa> GetEquipasList();
        List<IArbitro> GetArbitrosList();
        bool ProcurarJogo(int id);
        void SetJogo();
        void Add(IJogo jogo);
        void GetJogo();
        void Find(int id);
        void UpdateJogo();
        void Update(IJogo jogo);
    }

    public class JogoController : IJogoController
    {
        #region Member Values
        
        private IJogo model;
        private IJogoView view;
        private IGuardaJogo list;
        
        #endregion

        #region Constructor
        public JogoController()
        {
            list = new GuardaJogo();
            list.Load("jogo.bin");
            view = new JogoView(this);
        }
        #endregion

        #region View-Model-File
        public void SetView(IJogoView v)
        {
            view = v;
        }

        public void SetListModel(IGuardaJogo m)
        {
            list = m;
        }

        public void SetModel(IJogo m)
        {
            model = m;
        }

        public void Save()
        {
            list.Save("jogo.bin");
        }
        #endregion

        #region Functions
        public void GetAllJogos()
        {
            int index = 0;
            if (view != null)
            {
                if (list != null)
                {
                    foreach (IJogo i in list.GiveList())
                    {
                        index++;
                        view.ShowAllJogos(i, index);
                    }
                }
            }
        }
        public List<IArbitro> GetArbitros(List<int> id)
        {
            List <IArbitro> list = new List<IArbitro>();
            IGuardaArbitro arbitros = new GuardaArbitro();
            arbitros.Load("arbitros.bin");
            foreach (int x in id)
            {
                IArbitro a = arbitros.Find(x);
                list.Add(a);
            }
            return list;
        }
        public List<IEquipa> GetEquipasList()
        {
            List<IEquipa> list = new List<IEquipa>();
            IGuardarEquipa equipas = new GuardarEquipa();
            equipas.Load("equipas.bin");
            return equipas.GiveList();
        }
        public bool ProcurarJogo(int id)
        {
            IJogo jogo;
            if (list != null)
            {
                jogo = list.Find(id);

                if (jogo != null)
                {
                    SetModel(jogo);
                    return true;
                }
            }
            return false;
        }
        public void SetJogo()
        {
            if (view != null)
            {
                view.AddJogo();
            }
        }
        public void Add(IJogo jogo) 
        {
            list.Add(jogo);
        }

        public void GetJogo()
        {
            if (view != null)
            {
                view.GetJogo();
            }
        }
        public void Find(int id)
        {
            if (list != null)
            {
                view.ShowOne(list.Find(id));
            }
        }
        public void UpdateJogo()
        {
            if (view != null)
            {
                view.UpdateJogo();
            }
        }
        public void Update(IJogo jogo)
        {
            if (list != null)
            {
                model.UpdateJogo(jogo);
            }
        }
        
        #endregion
    }
}
