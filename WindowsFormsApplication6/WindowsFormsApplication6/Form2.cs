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

namespace WindowsFormsApplication6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("Favourite.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Favourite.xml");
                XmlNode webName = doc.CreateElement("WebsiteName");
                XmlNode web = doc.CreateElement("Website");

                web.InnerText = textBoxURL.Text;
                webName.InnerText = textBoxUrlName.Text;
                doc.DocumentElement.AppendChild(webName);
                doc.DocumentElement.AppendChild(web);
                doc.Save("Favourite.xml");
            }
            else
            {
                XmlTextWriter tw = new XmlTextWriter("Favourite.xml", Encoding.UTF8);
                tw.WriteStartElement("Favourite");
                tw.WriteStartElement("Website");
                tw.WriteStartElement("Name");
                tw.WriteString(textBoxURL.Text);
                tw.WriteString(textBoxUrlName.Text);

                tw.WriteEndElement();
                tw.WriteEndElement();
                tw.WriteEndElement();

                tw.Close();
            }
            MessageBox.Show("Favourite has been saved");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
