using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract17
{
    public  class Fiction: Books
    {
        public string janr;
        public string  Janr
        {
            get { return janr; }
            set { janr = value; }
        }

        public override string Info() 
        {
            return $"Название: {Nick}, Автор: {Avtor}, Год выпуска: {Godvipuska}, Иллюстраций: {Kartinki}, Жанр: {Janr}";
        }
        
        
       

       
    }
}
