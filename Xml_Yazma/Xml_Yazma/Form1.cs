using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Xml_Yazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xml = new XmlDocument();
        XmlElement filmler;
        private void Form1_Load(object sender, EventArgs e)
        {
    
            if (!File.Exists("Filmler.xml"))//Dosya yoksa
            {
               filmler = xml.CreateElement("filmler");
               xml.AppendChild(filmler);

            }
            else//Dosya varsa
            {
                xml.Load("Filmler.xml");
                filmler=(XmlElement)xml.SelectSingleNode("filmler");

                XmlNodeList film = filmler.SelectNodes("film");
                foreach (XmlNode f in film)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = f.Attributes["adi"].Value;
                    lvi.SubItems.Add(f.Attributes["turu"].Value);
                    lvi.SubItems.Add(f.Attributes["yili"].Value);
                    lvi.SubItems.Add(f.Attributes["yonetmen"].Value);
                    lvi.SubItems.Add(f.Attributes["IMDBpuani"].Value);

                    listView1.Items.Add(lvi);
                    
                }
            }

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            XmlElement film = xml.CreateElement("film");

            XmlAttribute adi = xml.CreateAttribute("adi");
            adi.Value = txtFilmAdi.Text;
            film.Attributes.Append(adi);

            XmlAttribute filmTuru = xml.CreateAttribute("turu");
            filmTuru.Value = cmbFilmTuru.Text;
            film.Attributes.Append(filmTuru);

            XmlAttribute yili = xml.CreateAttribute("yili");
            yili.Value = dtpYapimYili.Value.Year.ToString();
            film.Attributes.Append(yili);

            XmlAttribute yonetmen = xml.CreateAttribute("yonetmen");
            yonetmen.Value = txtYonetmen.Text;
            film.Attributes.Append(yonetmen);

            XmlAttribute IMDBpuani = xml.CreateAttribute("IMDBpuani");
            IMDBpuani.Value = txtIMDBpuani.Text;
            film.Attributes.Append(IMDBpuani);

            XmlElement oyuncular = xml.CreateElement("oyuncular");

            foreach (string oyuncu in listOyuncular.Items)
            {
                XmlElement o = xml.CreateElement("oyuncu");
                o.InnerText = oyuncu;
                oyuncular.AppendChild(o);
            }
            film.AppendChild(oyuncular);
            filmler.AppendChild(film);
            xml.Save("Filmler.xml");
            


        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            listOyuncular.Items.Add(txtOyuncuAdi.Text);
            txtOyuncuAdi.Text = "";
        }

        private void btnDbToXml_Click(object sender, EventArgs e)
        {
            DbToXmlForm dbtoXml = new DbToXmlForm();
            dbtoXml.ShowDialog();
        }
    }
}
            