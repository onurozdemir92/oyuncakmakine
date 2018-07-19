using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace oyuncakmakine
{
    public partial class Form1 : Form
    {
        int move, mouse_x, mouse_y;
        int islemsayisi = 0;
        int adim;
        int calisma = 1;
        ListBox bellekad = new ListBox();
        ListBox bellekdeger = new ListBox();
        public static string[] parcalar;
        public static float aku;
        String bellekad1;
        float bellekdeger1;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, Convert.ToInt32(comboBox1.SelectedItem.ToString()));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 6;
            textBox1.ScrollBars = ScrollBars.Vertical;


        }

        private void button4_Click(object sender, EventArgs e)
        { if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calisma = 1;
            islemsayisi = 0;
            bellekad.Items.Clear();
            bellekdeger.Items.Clear();
            bellegegec();
            listBox1.Items.Clear();
            parcalar = textBox1.Text.Split('\n');
            for (int i = 0; i < parcalar.Count(); i++)
            {
                if (i == parcalar.Count())
                {
                    calisma = 0;

                }
                else if (calisma == 1)
                {
                    islem(parcalar[i].Trim());

                }
                else
                {
                    break;
                }
                

            }
            //foreach (String komut in parcalar)
            //{if (komut.StartsWith("stop")) break;
            //    if (!komut.StartsWith(" "))
            //    {


            //        if (islemkontrol())
            //        {

            //            break;
            //        }
            //        else
            //        {
            //            islem(komut);
            //        }
            //    }
                
                
            //}
           
        }
        public void islem(String islem)
        {
            ++islemsayisi;
                if (calisma == 1)
                {
                    try
                    {
                        String b = ":";
                        if (islem.StartsWith("get")) get();
                        else if (islem.StartsWith(" ")) { }

                        else if (islem.StartsWith("print")) print();
                        else if (islem.StartsWith("add")) add(islem);
                        else if (islem.StartsWith("mod")) mod(islem);
                        else if (islem.StartsWith("sub")) sub(islem);
                        else if (islem.StartsWith("div")) div(islem);
                        else if (islem.StartsWith("goto")) Goto(islem);

                        else if (islem.StartsWith("stop")) calisma = 0;
                        else if (islem.StartsWith("ifpos")) ifpos(islem);
                        else if (islem.StartsWith("ifzero")) ifzero(islem);
                        else if (islem.StartsWith("ifcift")) ifcift(islem);
                        else if (islem.StartsWith("iftek")) iftek(islem);
                        else if (islem.IndexOf(b) != -1) { }
                        else if (islem.StartsWith("mul")) mul(islem);
                        else if (islem.StartsWith("-")) { }
                        else if (islem.StartsWith("load")) load(islem);
                        else if (islem.StartsWith("store")) store(islem);
                    }
                    catch
                    {

                    }

                }
           
          

        
            
           
           
        }
        public void adimislem(String islem)
        {
            try
            {
                String b = ":";
                if (islem.StartsWith("get")) get();
                else if (islem.StartsWith(" ")) { }

                else if (islem.StartsWith("print")) print();
                else if (islem.StartsWith("add")) add(islem);
                else if (islem.StartsWith("mod")) mod(islem);
                else if (islem.StartsWith("sub")) sub(islem);
                else if (islem.StartsWith("div")) div(islem);

                else if (islem.StartsWith("goto")) adimGoto(islem);



                else if (islem.StartsWith("ifpos")) adimifpos(islem);
                else if (islem.StartsWith("ifzero")) adimifzero(islem);
                else if (islem.StartsWith("ifcift")) adimifcift(islem);
                else if (islem.StartsWith("iftek")) adimiftek(islem);
                else if (islem.IndexOf(b) != -1) { }
                else if (islem.StartsWith("mul")) mul(islem);
                else if (islem.StartsWith("-")) { }
                else if (islem.StartsWith("load")) load(islem);
                else if (islem.StartsWith("store")) store(islem);
                else
                {
                    // listBox1.Items.Add(islem + " Bu Komut Hatalidir"+ islem.Length);

                };

            }
            catch
            {

            }
            
            
        }
        public void adimiftek(String islem)
        {
            try
            {
                if (aku % 2 != 0)
                {
                    String[] a = islem.Split(' ');
                    String c = a[a.Length - 1].Trim() + ":";
                    for (int i = 0; i < parcalar.Length; i++)
                    {

                        if (parcalar[i].StartsWith(c))
                        {

                            adim = i;
                            break;
                        }
                    }
                }

            }
           
            catch
            {
                listBox2.Items.Add("Bu satirda Yazim Hatasi bulunmakdadir");
            }
           
        }
        public void iftek(String islem)
        {
            
            if (aku % 2 != 0)
            {
                String[] a = islem.Split(' ');
                String c = a[a.Length - 1].Trim() + ":";
                for (int i = 0; i < parcalar.Length; i++)
                {
                    if (islemkontrol())
                    {
                        
                        break;
                    }
                    else
                    {
                        if (parcalar[i].StartsWith(c))
                        {

                            dallan(i);
                            break;
                        }
                    }

                  
                }
            }
            try
            {

            }
            catch
            {
                listBox2.Items.Add("Bu satirda Yazim Hatasi bulunmakdadir");
            }
        }
        public void ifcift(String islem)
        {
           
           
            try
            {
                if (aku % 2 == 0)
                {
                    String[] a = islem.Split(' ');
                    String c = a[a.Length - 1].Trim() + ":";
                    for (int i = 0; i < parcalar.Length; i++)
                    {
                        if (islemkontrol())
                        {

                            break;
                        }
                        else
                        {
                            if (parcalar[i].StartsWith(c))
                            {

                                dallan(i);
                                break;
                            }

                        }


                    }
                }

            }
            catch
            {
                listBox2.Items.Add("Bu satirda Yazim Hatasi bulunmakdadir");
            }
        }
        public void adimifcift(String islem)
        {
          
            try
            {
                if (aku % 2 == 0)
                {
                    String[] a = islem.Split(' ');
                    String c = a[a.Length - 1].Trim() + ":";
                    for (int i = 0; i < parcalar.Length; i++)
                    {

                        if (parcalar[i].StartsWith(c))
                        {

                            adim = i;
                            break;
                        }
                    }
                }

            }
            catch
            {
                listBox2.Items.Add("Bu satirda Yazim Hatasi bulunmakdadir");
            }
        }
        public void adimifpos(String islem)
        {

            try
            {
                if (aku >= 0)
                {
                    String[] a = islem.Split(' ');
                    String c = a[a.Length - 1].Trim() + ":";
                    for (int i = 0; i < parcalar.Length; i++)
                    {

                        if (parcalar[i].StartsWith(c))
                        {

                            adim = i;
                            break;
                        }
                    }
                }

            }
            catch
            {
                listBox2.Items.Add("Bu satirda Yazim Hatasi bulunmakdadir");
            }

        }
        public void ifpos(String islem)
        {
            try
            {
                if (aku >= 0)
                {
                    String[] a = islem.Split(' ');
                    String c = a[a.Length - 1].Trim() + ":";
                    for (int i = 0; i < parcalar.Length; i++)
                    {
                        if (islemkontrol())
                        {

                            break;
                        }
                        else
                        {
                            if (parcalar[i].StartsWith(c))
                            {

                                dallan(i);
                                break;
                            }
                        }


                    }
                }
            }
            catch
            {

            }
            
        }
        public void temizle()
        {
            adbel0.Clear();
            adbel1.Clear();
            adbel2.Clear();
            adbel3.Clear();
            adbel4.Clear();
            adbel5.Clear();
            adbel6.Clear();
            adbel7.Clear();
            degbel0.Clear();
            degbel1.Clear();
            degbel2.Clear();
            degbel3.Clear();
            degbel4.Clear();
            degbel5.Clear();
            degbel6.Clear();
            degbel7.Clear();
            bellekad.Items.Clear();
            bellekdeger.Items.Clear();
            listBox1.Items.Clear();
            textBox1.Clear();
            aku = 0;
            txtaku.Clear();
            listBox2.Items.Clear();
        }
        public void bellegegec()
        {
            if (bellekad.Items.Count == 0)
            {
                adbel0.Clear();
                adbel1.Clear();
                adbel2.Clear();
                adbel3.Clear();
                adbel4.Clear();
                adbel5.Clear();
                adbel6.Clear();
                adbel7.Clear();
            }
            if (bellekdeger.Items.Count == 0)
            {
                degbel0.Clear();
                degbel1.Clear();
                degbel2.Clear();
                degbel3.Clear();
                degbel4.Clear();
                degbel5.Clear();
                degbel6.Clear();
                degbel7.Clear();
            }
            
            if (bellekad.Items.Count-1<=7)
            for (int i = 0; i < bellekad.Items.Count; i++)
            {
                    switch (i)
                    {
                        case 0 :
                            adbel0.Text = bellekad.Items[i].ToString();
                            break;
                        case 1:
                            adbel1.Text = bellekad.Items[i].ToString();
                            break;
                        case 2:
                            adbel2.Text = bellekad.Items[i].ToString();
                            break;
                        case 3:
                            adbel3.Text = bellekad.Items[i].ToString();
                            break;
                        case 4:
                            adbel4.Text = bellekad.Items[i].ToString();
                            break;
                        case 5:
                            adbel5.Text = bellekad.Items[i].ToString();
                            break;
                        case 6:
                            adbel6.Text = bellekad.Items[i].ToString();
                            break;
                        case 7:
                            adbel7.Text = bellekad.Items[i].ToString();
                            break;
                        

                    }
                    
            }
            else
            {
                listBox1.Items.Add("Bellege en fazla 7 farkli deger atila bilir programiniz dogru calismaya bilir!");
            }
            if (bellekdeger.Items.Count - 1 <= 7)
                for (int i = 0; i < bellekdeger.Items.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            degbel0.Text = bellekdeger.Items[i].ToString();
                            break;
                        case 1:
                            degbel1.Text = bellekdeger.Items[i].ToString();
                            break;
                        case 2:
                            degbel2.Text = bellekdeger.Items[i].ToString();
                            break;
                        case 3:
                            degbel3.Text = bellekdeger.Items[i].ToString();
                            break;
                        case 4:
                            degbel4.Text = bellekdeger.Items[i].ToString();
                            break;
                        case 5:
                            degbel5.Text = bellekdeger.Items[i].ToString();
                            break;
                        case 6:
                            degbel6.Text = bellekdeger.Items[i].ToString();
                            break;
                        case 7:
                            degbel7.Text = bellekdeger.Items[i].ToString();
                            break;

                    }
                }
            else
            {
                
            }
        }
        public void adimifzero(String islem)
        {
            try
            {
                if (aku == 0)
                {

                    String[] a = islem.Split(' ');

                    String c = a[a.Length - 1].Trim() + ":";
                    for (int i = 0; i < parcalar.Length; i++)
                    {

                        if (parcalar[i].StartsWith(c))
                        {

                            adim = i;
                            break;
                        }
                    }
                }
            }
            catch
            {
                listBox2.Items.Add("Bu satirda yazim hatasi bulunmakdadir");
            }

        }
        public void ifzero(String islem)
        {
            try
            {
                if (aku == 0)
                {

                    String[] a = islem.Split(' ');

                    String c = a[a.Length - 1].Trim() + ":";
                    for (int i = 0; i < parcalar.Length; i++)
                    {
                        if (islemkontrol())
                        {

                            break;
                        }
                        else
                        {
                            if (parcalar[i].StartsWith(c))
                            {

                                dallan(i);
                                break;
                            }

                        }


                    }
                }
            }
            catch
            {

            }

        }
        public void stop()
        {
            
        }
        public void sub(String islem)
        {
            String[] a = islem.Split(' ');
            try
            {
                float x = float.Parse(a[a.Length - 1]);
                aku = aku - x;
                txtaku.Text = aku.ToString();
            }
            
              catch
            {
                int kont = degervarmi(a[a.Length - 1].Trim());
                if (kont == -1)
                {
                    listBox1.Items.Add(a[a.Length - 1].Trim() + " Adinda Bellekde Kayitli Degisken Yoktur");
                }
                else
                {
                    
                    aku = aku - float.Parse(bellekdeger.Items[kont].ToString());
                    txtaku.Text = aku.ToString();
                }
            }
        }
       
        public void div(String islem)
        {
            String[] a = islem.Split(' ');
            try
            {
                float x = float.Parse(a[a.Length - 1]);
                aku = aku / x;
                txtaku.Text = aku.ToString();
            }
            catch
            {
                int kont = degervarmi(a[a.Length - 1].Trim());
                if (kont == -1)
                {
                    listBox1.Items.Add(a[a.Length - 1].Trim() + " Adinda Bellekde Kayitli Degisken Yoktur");
                }
                else
                {

                    aku = aku/float.Parse(bellekdeger.Items[kont].ToString());
                    txtaku.Text = aku.ToString();
                }
            }

        }

        public void mul(String islem)
        {
            String[] a = islem.Split(' ');
            try
            {
                float x = float.Parse(a[a.Length - 1]);
                aku = aku * x;
                txtaku.Text = aku.ToString();
            }
            catch
            {
                int kont = degervarmi(a[a.Length - 1].Trim());
                if (kont == -1)
                {
                    listBox1.Items.Add(a[a.Length - 1].Trim() + " Adinda Bellekde Kayitli Degisken Yoktur");
                }
                else
                {
                    
                    aku = aku * float.Parse(bellekdeger.Items[kont].ToString());
                    txtaku.Text = aku.ToString();
                }
            }

        }
        public void adimGoto(String islem)
        {
            try
            {
                String[] a = islem.Split(' ');
                String c = a[a.Length - 1].Trim() + ":";
                for (int i = 0; i < parcalar.Length; i++)
                {

                    if (parcalar[i].IndexOf(c) != -1)
                    {

                        adim = i;
                        break;
                    }
                }
            }
            catch
            {
                listBox2.Items.Add("Goto komutunda yazim hatasi bulunmakdadir");
            }

        }
        public void Goto(String islem){
            try
            {
                String[] a = islem.Split(' ');
                String c = a[a.Length - 1].Trim() + ":";
                for (int i = 0; i < parcalar.Length; i++)
                {

                    if (parcalar[i].IndexOf(c) != -1)
                    {
                        if (calisma == 1)
                        {
                            if (islemkontrol())
                            {

                                break;
                            }
                            else
                            {
                                dallan(i);
                                break;
                            }
                        }

                    }
                }
            }
            catch
            {
                listBox2.Items.Add("Goto komutunda yazim hatasi bulunmakdadir");
            }
            
        }
        public bool islemkontrol()
        {
            if (islemsayisi > 10000) return true;
            else return false;
        }
        public void dallan(int satir)
        {
            
            for (int i = satir+1; i < parcalar.Length; i++)
            {
                if (calisma == 1)
                {

                    if (islemkontrol())
                    {

                        break;
                    }
                    else
                    {
                        islem(parcalar[i]);

                    }
                }
                
            }

        }
        public void get()
        {
            get g = new get();
            g.ShowDialog();
            txtaku.Text = aku.ToString();
           
        }
        public void print()
        {
            listBox1.Items.Add(aku);
        }
        public void load(String islem)
        {
            String []a = islem.Split(' ');
            try
            {
                aku = float.Parse(a[a.Length - 1].Trim());
                txtaku.Text = aku.ToString();
            }
            catch
            {
                int kont = degervarmi(a[a.Length - 1].Trim());
                if (kont == -1)
                {
                    listBox1.Items.Add(a[a.Length - 1].Trim() + " Adinda Bellekde Kayitli Degisken Yoktur");
                }
                else
                {
                    aku = float.Parse(bellekdeger.Items[kont].ToString());
                    txtaku.Text = aku.ToString();
                }
            }
          

        }
        public int degervarmi(String deger)
        {
            int kont = bellekkontrol(deger);
            if (kont != -1)
            {
                return kont;
            }
            else return -1;
        }
        public void mod(String islem)
        {
            


            String[] a = islem.Split(' ');
            try
            {
                float x = float.Parse(a[a.Length - 1]);
                aku = aku % x;
                txtaku.Text = aku.ToString();
            }
            catch
            {
                int kont = degervarmi(a[a.Length - 1].Trim());
                if (kont == -1)
                {
                    listBox1.Items.Add(a[a.Length - 1].Trim() + " Adinda Bellekde Kayitli Degisken Yoktur");
                }
                else
                {
                  
                    aku = aku % float.Parse(bellekdeger.Items[kont].ToString());
                    txtaku.Text = aku.ToString();
                }
            }

        }
        public void add(String islem)
        {
            String[] a = islem.Split(' ');
            try
            {
                float x = float.Parse(a[a.Length - 1]);
                aku = aku + x;
                txtaku.Text = aku.ToString();
            }
            catch
            {
                int kont = degervarmi(a[a.Length - 1].Trim());
                if (kont == -1)
                {
                    listBox1.Items.Add(a[a.Length - 1].Trim() + " Adinda Bellekde Kayitli Degisken Yoktur");
                }
                else
                {
                    aku = aku + float.Parse(bellekdeger.Items[kont].ToString());
                    txtaku.Text = aku.ToString();
                }
            }

        }
        public void store(String islem)
        {
            try
            {
                String[] a = islem.Split(' ');

                bellekad1 = a[a.Length - 1].Trim();
                bellekdeger1 = aku;
                int kont = bellekkontrol(bellekad1);
                if (kont != -1)
                {
                    bellekad.Items[kont] = bellekad1;

                    bellekdeger.Items[kont] = bellekdeger1;
                }
                else
                {
                    bellekad.Items.Add(bellekad1);
                    bellekdeger.Items.Add(bellekdeger1);

                }

                bellegegec();
            }
            catch
            {

            }

        }
        public int bellekkontrol(String ad)
        {
            for (int i = 0; i < bellekad.Items.Count; i++)
            {
                if (ad == bellekad.Items[i].ToString()) return i;
            }
            return -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Metin Dosyasi |*.txt;";
            dosya.Title = "Dosya Seciniz";
            
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = dosya.FileName;
                StreamReader sr = new StreamReader(DosyaYolu);

                textBox1.Text = sr.ReadToEnd();
            } 
            
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Metin Dosyası|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(textBox1.Text);
                Kayit.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            adim = 0;
            temizle();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            adim = 0;
            aku = 0;
            txtaku.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            bellekad.Items.Clear();
            bellekdeger.Items.Clear();
            bellegegec();
            parcalar = textBox1.Text.Split('\n');
            foreach (String komut in parcalar)
            {

                listBox2.Items.Add(komut);


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count != 0)
            {
                if (adim > parcalar.Count() - 1)
                {
                    adim = 0;
                    listBox1.Items.Clear();
                    bellekad.Items.Clear();
                    bellekdeger.Items.Clear();
                    bellegegec();
                    aku = 0;
                    txtaku.Clear();
                    
                }
                else
                {

                    listBox2.SelectedIndex = adim;
                    String komut = listBox2.Items[adim].ToString();
                    adimislem(komut.Trim());
                    ++adim;

                }
            }
            

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yardim y = new yardim();
            y.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
    }
}
