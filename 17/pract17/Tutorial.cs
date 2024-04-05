using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract17
{
    public class Tutorial : Books
    {
        int kolekzemp;
        string discp;

        public int Kolekzemp
        {
            get { return kolekzemp; }
            set { kolekzemp = value; }
        }
        public string Discp
        {
            get { return discp; }
            set { discp = value; }
        }
        public override string Info() 
        {
            return $"Название: {Nick}, Автор: {Avtor}, Год выпуска: {Godvipuska}, Иллюстраций: {Kartinki}, Кол-во:{kolekzemp}, Дисциплина: {Discp} ";
        }
    }
}
