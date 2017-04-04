using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquetteABI
{
    class Outils
    {/// <summary>
    /// mes outils contiennent la methode qui verifie si c'est un entier ou pas
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
        public static Boolean EstEntier(string s)
        {
            char c;
            Boolean code = true;

            if (s.Length < 15 && s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(Char.IsDigit(c)))
                    {
                        code = false;
                    }
                }
            }
            else
            {
                code = false;
            }
            return code;
        }
        public static Boolean Controle(String text)
        {
            Boolean code = true;
            if (!(Outils.EstEntier(text)))
            {
                code = false;
            }
            return code;
        }
   }
}
