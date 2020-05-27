using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoLP.Models
{
    class Ficheiro
    {
        #region CONSTRUCTORS
        public Ficheiro() { }
        #endregion

        #region FUNCTIONS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ficheiro">Path do ficheiro</param>
        /// <param name="conteudo">Linhas para inserir no ficheiro</param>
        /*public static void Salvar(string ficheiro, string[] conteudo)
        {
            if (File.Exists(ficheiro))
            {
                try
                {
                    StreamWriter sw = File.AppendText(ficheiro);
                    File.WriteAllLines(ficheiro, conteudo);
                }
                catch (Exception e)
                {
                    Console.Write("ERRO:" + e.Message);
                }
            }
            else
            {
                StreamWriter sw = File.CreateText(ficheiro); 
                File.WriteAllLines(ficheiro, conteudo);
            }
        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ficheiro">Path do ficheiro</param>
        public static array Buscar(string ficheiro)
        /*{
            if (File.Exists(ficheiro))
            {
                try
                {
                    StreamWriter sw = File.AppendText(ficheiro);
                    File.WriteAllLines(ficheiro, conteudo);
                }
                catch (Exception e)
                {
                    Console.Write("ERRO:" + e.Message);
                }
            }
            else
            {
                StreamWriter sw = File.CreateText(ficheiro);
                File.WriteAllLines(ficheiro, conteudo);
            }
        }*/
        #endregion
    }
}
