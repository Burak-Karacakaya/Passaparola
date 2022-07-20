using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki soruyu görmek istiyorum.";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Beceriksiz, İş Bilmez, Tertipsiz, Şaşkın?"; //Aciz
                buttonA.BackColor = Color.Yellow;


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Duttan Elde Edilen İlk Şıra?"; //Burun
                buttonB.BackColor = Color.Yellow;


            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Şubat Sonlarında, Sırayla Havaya, Suya Ve Toprağa Düşerek Oluştuğu Sanılan Sıcaklık Yükselişi?"; // Cemre
                buttonC.BackColor = Color.Yellow;


            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Eskiden Cilt Yerine Kullanılan Bir Terim?"; // Defter
                buttonD.BackColor = Color.Yellow;


            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Söylence?"; //Efsane
                buttonE.BackColor = Color.Yellow;


            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Duvar ya da taban kaplaması olarak kullanılan pişmiş balçık levha?"; // Fayans
                buttonF.BackColor = Color.Yellow;


            }
            if (soruno == 7)
            {
                richTextBox1.Text = "İki Çeneklilerden, Uzun Dikenli Ve Kürecikler Hâlinde Çiçekleri Olan Bir Kaktüs Türü?"; //Greyfurt
                buttonG.BackColor = Color.Yellow;


            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Dervişlerin tapınma için tek başlarına bir yere kapanmaları?"; //Halfet
                buttonH.BackColor = Color.Yellow;


            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Güney Ve Orta Amerika'da Yaşayan, Postu Benekli Ve İri Gövdeli Bir Hayvan?"; // Jaguar
                buttonJ.BackColor = Color.Yellow;


            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Terazi gözü?"; //Kefe
                buttonK.BackColor = Color.Yellow;


            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Hafif Aydınlık?"; //Loş
                buttonL.BackColor = Color.Yellow;


            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Tarlaları ayırmak için sürülmeden bırakılan yer, sınır?"; //Melis
                buttonM.BackColor = Color.Yellow;


            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Yansız, tarafsız?"; // Nötr
                buttonN.BackColor = Color.Yellow;


            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Argoda Oyuna Getirme, Tuzağa Düşürme?"; //Oltalama
                buttonO.BackColor = Color.Yellow;


            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Bakıra çinko karıştırılarak elde edilen bir alaşım?"; //Pirinç
                buttonP.BackColor = Color.Yellow;


            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Perhiz?"; //Rejim
                buttonR.BackColor = Color.Yellow;


            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Mürekkep balığından elde edilen koyu siyah boyaya ve bu boya ile yapılan resimlere verilen ad?"; //Sepya
                buttonS.BackColor = Color.Yellow;


            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Zehir korkusu?"; //Toksifobi
                buttonT.BackColor = Color.Yellow;


            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Bir kimseyi ağırlamak, ona saygı göstermek?"; //Ululamak
                buttonU.BackColor = Color.Yellow;


            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Terazi yapıp satan kimse?"; //Vezneci
                buttonV.BackColor = Color.Yellow;


            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Değirmenlerde, Taşla Kasnak Arasında Kalan Ve Hayvan Yemi Olarak Kullanılan Un?"; //Yöre
                buttonY.BackColor = Color.Yellow;


            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Telli Bir Çalgıyı Acemice Çalarak Çıkarılan Çirkin Sesin Adı?"; //Zımbırtı
                buttonZ.BackColor = Color.Yellow;


            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "aciz")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "burun")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cemre")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "defter")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "efsane")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fayans")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "greyfurt")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halfet")
                        {
                            buttonH.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "jaguar")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "kefe")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "loş")
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "melis")
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "nötr")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "oltalama")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "pirinç")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "rejim")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "sepya")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "toksifobi")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "ulumak")
                        {
                            buttonU.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "vezneci")
                        {
                            buttonV.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "yöre")
                        {
                            buttonY.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "zımbırtı")
                        {
                            buttonZ.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;

                }
            }
        }
    }
}
