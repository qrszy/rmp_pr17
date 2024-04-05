namespace pract17form
{


    public partial class Form1 : Form
    {
        List<string[]> knigi = new List<string[]>();
        List<string[]> ycheb = new List<string[]>();
        static bool Bukvi(string x, out bool X)
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
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {


        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                label5.Text = "Кол-во";
                label6.Text = "Дисциплина";
                textBox6.Visible = true;
                label6.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                label6.Visible = false;
                textBox6.Visible = false;
                label5.Text = "Жанр";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_Enter(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;

        }

        private void radioButton2_Enter(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string nado = textBox1.Text;
                dataGridView1.Rows.Clear();
                for (int i = 0; i < knigi.Count; i++)
                {
                    if (knigi[i][0] == nado || knigi[i][1] == nado || knigi[i][2] == nado || knigi[i][3] == nado || knigi[i][4] == nado)
                    {
                        dataGridView1.Rows.Add(knigi[i][0], knigi[i][1], knigi[i][2], knigi[i][3], knigi[i][4]);
                    }
                }
            }
            else
                if (radioButton2.Checked)
            {
                string nado = textBox1.Text;
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ycheb.Count; i++)
                {
                    if (ycheb[i][0] == nado || ycheb[i][1] == nado || ycheb[i][2] == nado || ycheb[i][3] == nado || ycheb[i][4] == nado || ycheb[i][5] == nado)
                    {
                        dataGridView1.Rows.Add(ycheb[i][0], ycheb[i][1], ycheb[i][2], ycheb[i][3], ycheb[i][4], ycheb[i][5]);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                bool X = false; int A = 0;
                string str;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                string name = str;
                X = false;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                string avtor = str;
                X = false;
                do
                {
                    try
                    {

                        A = Convert.ToInt32(textBox3.Text);
                        str = A.ToString();
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (!Char.IsNumber(str[i])) X = false;
                        }
                    }
                    catch { MessageBox.Show("Введите число", "Ошибка"); }
                } while (X == true);
                int god = A;
                X = false;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                string kartinki = str;
                X = false;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                string janr = str;
                X = false;
                StreamWriter o = File.AppendText("k.txt");
                o.WriteLine(name);
                o.WriteLine(avtor);
                o.WriteLine(god);
                o.WriteLine(kartinki);
                o.WriteLine(janr);
                o.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                bool X = false; int A = 0;
                string str, name = "", avtor = "", kartinki = "", discp = "";
                int god=-1, kolvo = -1;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                name = str;
                X = false;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                 avtor = str;
                X = false;
                do
                {
                    try
                    {

                        A = Convert.ToInt32(textBox3.Text);
                        str = A.ToString();
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (!Char.IsNumber(str[i])) X = false;
                        }
                    }
                    catch { MessageBox.Show("Введите число", "Ошибка"); }
                } while (X == true);
               god = A;
                X = false;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                 kartinki = str;
                X = false;
                do
                {
                    try
                    {

                        A = Convert.ToInt32(textBox3.Text);
                        str = A.ToString();
                        for (int i = 0; i < str.Length; i++)
                        {
                            if (!Char.IsNumber(str[i])) X = false;
                        }
                    }
                    catch { MessageBox.Show("Введите число", "Ошибка"); }
                } while (X == true);
                 kolvo = A;
                X = false;
                do
                {
                    str = textBox1.Text;
                    Bukvi(str, out X);
                } while (X != true);
                 discp = str;
                X = false;
                if (name != "" &&) {
                    StreamWriter o = File.AppendText("y.txt");
                    o.WriteLine(name);
                    o.WriteLine(avtor);
                    o.WriteLine(god);
                    o.WriteLine(kartinki);
                    o.WriteLine(kolvo);
                    o.WriteLine(discp);
                    o.Close();
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

            StreamReader sw = File.OpenText("k.txt");
            while (!sw.EndOfStream)
            {
                string[] mas = new string[5];
                for (int j = 0; j < 5; j++)
                {
                    string st = sw.ReadLine();
                    mas[j] = st;
                }
                knigi.Add(mas);
            }
            sw.Close();
            StreamReader s = File.OpenText("y.txt");
            while (!sw.EndOfStream)
            {
                string[] mas = new string[6];
                for (int p = 0; p < 6; p++)
                {
                    string st = s.ReadLine();
                    mas[p] = st;
                }
                ycheb.Add(mas);
            }
            sw.Close();
        }
    }
}