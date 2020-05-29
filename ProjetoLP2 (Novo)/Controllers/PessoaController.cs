using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLP2.Models;
using ProjetoLP2.Views;

namespace ProjetoLP2.Controllers
{
    public interface IPessoaController
    {
        void SetView(IPessoaView v);
        void SetModel(IGuardaPessoa m);
        void SetModel(IPessoa m);
        void GetAll();
        void SetPessoa();
        void Add(IPessoa pessoa);
        void GetPessoa();
        void Find(int id);
        void UpdatePessoa();
        bool ProcurarCliente(int id);
        void Update(IPessoa pessoa);
    }

    class PessoaController : IPessoaController
    {
        #region Member Values
        private IPessoa model;
        private IPessoaView view; 
        private IGuardaPessoa list;
        #endregion

        #region Constructor
        public PessoaController()
        {
            list = new GuardaPessoa();
            list.Load("pessoa.bin");
            view = new PessoaView(this);
        }
        #endregion

        #region View-Model-File
        public void SetView(IPessoaView v)
        {
            this.view = v;
        }

        public void SetModel(IGuardaPessoa m)
        {
            list = m;
        }

        public void SetModel(IPessoa m)
        {
            model = m;
        }

        public void Save()
        {
            list.Save("pessoa.bin");
        }
        #endregion

        #region Functions
        public void GetAll()
        {
            int index = 0;
            if (view != null)
            {
                if (list != null)
                {
                    foreach (IPessoa i in list.GiveList())
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

        public void SetPessoa()
        {
            if (view != null)
            {
                view.AddPessoa();
            }
        }
        public void Add(IPessoa pessoa) // Recebe dados da view para enviar para o model adicionar um Cliente
        {
            list.Add(pessoa);
        }

        public void GetPessoa()
        {
            if (view != null)
            {
                view.GetPessoa();
            }
        }
        public void Find(int id)
        {
            if (list != null)
            {
                view.ShowOne(list.Find(id));
            }
        }
        public void UpdatePessoa()
        {
            if (view != null)
            {
                view.UpdatePessoa();
            }
        }
        public bool ProcurarCliente(int id)
        {
            IPessoa pessoa;
            if (list != null)
            {
                pessoa = list.Find(id);

                if (pessoa != null)
                {
                    SetModel(pessoa);
                    return true;
                }
            }
            return false;
        }
        public void Update(IPessoa pessoa)
        {
            if (list != null)
            {
                model.UpdateCliente(pessoa);
            }
        }
        #endregion
    }
}
