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
    public interface IArbitroController
    {
        void SetView(IArbitroView v);
        void SetListModel(IGuardaArbitro m);
        void SetModel(IArbitro m);
        void GetAllArbitros();
        bool ProcurarArbitro(int id);
        void SetArbitro();
        void Add(IArbitro pessoa);
        void GetArbitro();
        void Find(int id);
        void UpdateArbitro();
        void Update(IArbitro arbitro);
        void DeleteArbitro();
        void Delete();
    }
    public class ArbitroController : IArbitroController
    {
        #region Member Values
        private IArbitro model;
        private IArbitroView view;
        private IGuardaArbitro list;
        #endregion

        #region Constructor
        public ArbitroController()
        {
            list = new GuardaArbitro();
            list.Load("arbitro.bin");
            view = new ArbitroView(this);
        }
        #endregion

        #region View-Model-File
        public void SetView(IArbitroView view)
        {
            this.view = view;
        }

        public void SetListModel(IGuardaArbitro m)
        {
            list = m;
        }

        public void SetModel(IArbitro m)
        {
            model = m;
        }

        public void Save()
        {
            list.Save("arbitro.bin");
        }
        #endregion

        #region Functions
        public void GetAllArbitros()
        {
            int index = 0;
            if (view != null)
            {
                if (list != null)
                {
                    foreach (IArbitro i in list.GiveList())
                    {
                        index++;
                        if (i.Active)
                        {
                            view.ShowAllArbitros(i, index);
                        }
                    }
                }
            }
        }
        public bool ProcurarArbitro(int id)
        {
            IArbitro arbitro;
            if (list != null)
            {
                arbitro = list.Find(id);

                if (arbitro != null)
                {
                    SetModel(arbitro);
                    return true;
                }
            }
            return false;
        }
        public void SetArbitro()
        {
            if (view != null)
            {
                view.AddArbitro();
            }
        }
        public void Add(IArbitro arbitro)
        {
            list.AddArbitro(arbitro);
        }

        public void GetArbitro()
        {
            if (view != null)
            {
                view.GetArbitro();
            }
        }
        public void Find(int id)
        {
            if (list != null)
            {
                view.ShowOneArbitro(list.Find(id));
            }
        }
        public void UpdateArbitro()
        {
            if (view != null)
            {
                view.UpdateArbitro();
            }
        }
        public void Update(IArbitro arbitro)
        {
            if (list != null)
            {
                model.UpdateArbitro(arbitro);
            }
        }
        public void DeleteArbitro()
        {
            if (view != null)
            {
                view.DeleteArbitro();
            }
        }
        public void Delete()
        {
            if (list != null)
            {
                model.DeleteArbitro();
            }
        }
        #endregion
    }
}
