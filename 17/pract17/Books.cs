using System.Reflection.Metadata.Ecma335;

namespace pract17
{
    public abstract class Books 
    {
        string nick;
        string avtor;
        int godvipuska;
        string kartinki;

        public abstract string Info(); 
        
        public string Nick 
        {
            get {return nick;}
            set { nick = value; }
        }
        public string Avtor
        {
            get { return avtor; }
            set { avtor = value; }
        }
        public int Godvipuska
        {
            get { return godvipuska; }
            set { godvipuska = value; }
        }
        public string Kartinki
        {
            get { return kartinki; }
            set { kartinki = value; }
        }
       public static bool Bukvi(string x,out bool X)
        {
            X = true;
            if (x != "")
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (!Char.IsLetter(x[i])) X = false;
                }
                return X;
            }
            else
            {
                X = false;
                return X;
            }
        } 

    }
}