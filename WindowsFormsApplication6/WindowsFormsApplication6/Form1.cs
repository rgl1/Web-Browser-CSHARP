using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;
using System.Net;
using System.Net.Http;
using System.Xml;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        //Create a Local History in order to navigate between pages within a session.
        List<List<string>> localHistory;
        List<int> localHistoryPointer;
        public Form1()
        {
            InitializeComponent();
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            this.tabPage1.Controls.Add(rtb);
            localHistory = new List<List<string>>();
            localHistoryPointer = new List<int>();
            localHistoryPointer.Add(0);
            localHistory.Add(new List<string>());
            label1.Text = "History";

            //statement to load the history file when web browser is launched
            if (File.Exists("History.xml"))
            {
                string path_of_xml = "History.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path_of_xml);
                listBox1.Items.Clear();
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string website = node.InnerText;
                    listBox1.Items.Add(website);
                }
            }
        }
        private async void btnGo_Click(object sender, EventArgs e)
        {
            //Check if the website URL entered has http
            if (!textBox1.Text.Contains("http"))
            {
                //if check is not true then t adds the following.
                textBox1.Text = "http://" + textBox1.Text;
            }
            string URL = textBox1.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                richTextBox1 = (RichTextBox)SelectedTab.SelectedTab.Controls[0];
                HttpClient c = new HttpClient();
                string result = await c.GetStringAsync(textBox1.Text);
                richTextBox1.Text = await c.GetStringAsync(textBox1.Text);
                sr.Close();

                //write the URL entered to an xml document
                if (File.Exists("History.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("History.xml");
                    XmlNode web = doc.CreateElement("Website");

                    web.InnerText = textBox1.Text;
                    doc.DocumentElement.AppendChild(web);
                    doc.Save("History.xml");

                }
                else
                {
                    //Check if the file isnt created then creates the document
                    XmlTextWriter tw = new XmlTextWriter("History.xml", Encoding.UTF8);
                    tw.WriteStartElement("History");
                    tw.WriteStartElement("Website");
                    tw.WriteString(textBox1.Text);
                    tw.WriteEndElement();
                    tw.WriteEndElement();
                    tw.Close();
                }
            }
            catch (WebException we)
            {
                if (((HttpWebResponse)we.Response).StatusCode.ToString() == "NotFound")
                {
                    this.richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.Text = "404 page not found"; }));
                }

                if (((HttpWebResponse)we.Response).StatusCode.ToString() == "403")
                {
                    this.richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.Text = "403 Forbidden"; }));
                }

                if (((HttpWebResponse)we.Response).StatusCode.ToString() == "400 BadRequest")
                {
                    this.richTextBox1.Invoke(new MethodInvoker(delegate { richTextBox1.Text = "400 Bad Request"; }));
                }                
            }
            finally
            {
                Console.WriteLine(1);
                if (localHistory[this.SelectedTab.SelectedIndex].Count != 0)
                {
                    if (URL != localHistory[this.SelectedTab.SelectedIndex][localHistoryPointer[this.SelectedTab.SelectedIndex]])
                    {
                        Console.WriteLine(2);
                        localHistory[this.SelectedTab.SelectedIndex].Add(URL);
                        localHistoryPointer[this.SelectedTab.SelectedIndex] = localHistory[this.SelectedTab.SelectedIndex].Count - 1;
                    }
                }
                else
                {
                    Console.WriteLine(3);
                    localHistory[this.SelectedTab.SelectedIndex].Add(URL);
                    localHistoryPointer[this.SelectedTab.SelectedIndex] = localHistory[this.SelectedTab.SelectedIndex].Count - 1;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void tSavFav_Click(object sender, EventArgs e)
        {
            //implement the form that will be used with adding a new favourite
            Form2 f2 = new Form2();
            f2.Show();            
        }
        //use of an xml file to save the Favourites that are saved
        private void tFav_Click(object sender, EventArgs e)
        {
            label1.Text = "Favourite";
            string path_of_xml = "Favourite.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path_of_xml);

            listBox1.Items.Clear();
            foreach (XmlNode node in doc.DocumentElement)
            {
                string website = node.InnerText;
                if(node.Name == "WebsiteName")
                    listBox1.Items.Add(website);
            }
        }
        //code in order to interate to previous tabs than current selected tab.
        private void tPreTab_Click(object sender, EventArgs e)
        {
            if (SelectedTab.SelectedIndex == 0)
                SelectedTab.SelectTab(SelectedTab.TabCount - 1);
            else
                SelectedTab.SelectTab(SelectedTab.SelectedIndex - 1);
        }
        //code in order to interate to the next tab than the current selected tab.
        private void tNextTab_Click(object sender, EventArgs e)
        {
            if (SelectedTab.SelectedIndex == SelectedTab.TabCount - 1)
                SelectedTab.SelectTab(0);
            else
                SelectedTab.SelectTab(SelectedTab.SelectedIndex + 1);
        }
        //Xml file that creates an entry of the URL saved as the home page.
        private async void btnHome_Click(object sender, EventArgs e)
        {
            if (File.Exists("Home.xml"))
            {
                string path_of_xml = "Home.xml";
                XmlDocument doc = new XmlDocument();

                doc.Load(path_of_xml);

                listBox1.Items.Clear();
                foreach (XmlNode node in doc.DocumentElement)
                {
                    string website = node.InnerText;
                    this.textBox1.Text = website;
                    btnGo_Click(null, null);
                }
            }
            else
            {
                //listBox1.Items.Clear();
            }
        }
        //use of natural numbers with odd and even numbers to be able to point one to another.
        private async void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string path_of_xml = "Favourite.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path_of_xml);
                int i = 0;
                foreach (XmlNode node in doc.DocumentElement)
                {
                    if (i == listBox1.SelectedIndex * 2 + 1)
                    {
                        textBox1.Text = node.InnerText;
                        btnGo_Click(null, null);
                        break;
                    }
                     i++;
                }
            }

            

        }
        //Reload the page, in other words refresh the current loaded page.
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            HttpClient c = new HttpClient();
            RichTextBox richTextBox1 = (RichTextBox)SelectedTab.SelectedTab.Controls[0];
            string result = await c.GetStringAsync(textBox1.Text);
            richTextBox1.Text = result;
            //insert message to show that the page is reloading.
            if (MessageBox.Show("page reloadinng", "page reloading", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                richTextBox1.Text = "";
                richTextBox1.Text = result;
            }
        }
        //code to return the items in the xml written after being loaded.
        private void tHist_Click(object sender, EventArgs e)
        {
            label1.Text = "History";
            if (File.Exists("History.xml"))
            {
                string path_of_xml = "History.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path_of_xml);
                listBox1.Items.Clear();
                

                foreach (XmlNode node in doc.DocumentElement)
                {
                   
                    string website = node.InnerText;
                    listBox1.Items.Add(website);
                    

                }
               
            }
            else
            {
                listBox1.Items.Clear();
            }
            

        }
        //if statement to clear the History file.
        private void tClearHist_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("History.xml"))
            {
                System.IO.File.Delete("History.xml");
            }
            
          
        }
        //code to write the current url to a file that will be read as the home page when selected.
        private void tSaveHomePgae_Click(object sender, EventArgs e)
        {
            XmlTextWriter tw = new XmlTextWriter("Home.xml", Encoding.UTF8);
            tw.WriteStartElement("Home");
            tw.WriteStartElement("Website");
            tw.WriteString(textBox1.Text);
            tw.WriteEndElement();
            tw.WriteEndElement();
            tw.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //code for initiating a new tab.
        private void tNewTab_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage();
            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            tp.Controls.Add(rtb);
            SelectedTab.TabPages.Add(tp);
            localHistoryPointer.Add(0);
            localHistory.Add(new List<string>());
        }            
        public class website
        {
            public string url;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //use of local history to redirect between pages with ia a tab
        private void btnPrePage_Click(object sender, EventArgs e)
        {
            if (localHistoryPointer[SelectedTab.SelectedIndex] != 0)
            {
                localHistoryPointer[SelectedTab.SelectedIndex]--;
                this.textBox1.Text = localHistory[this.SelectedTab.SelectedIndex][localHistoryPointer[this.SelectedTab.SelectedIndex]];
                btnGo_Click(null, null);
            }
            else
            {
                MessageBox.Show("Can't go any further back");
            }
        }
        bool first = true;
        //use of local history to display pages alreaady been loaded by a specific page.
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (localHistoryPointer[SelectedTab.SelectedIndex] != localHistory[SelectedTab.SelectedIndex].Count - 1 && !first)
            {
                localHistoryPointer[SelectedTab.SelectedIndex]++;
                this.textBox1.Text = localHistory[this.SelectedTab.SelectedIndex][localHistoryPointer[this.SelectedTab.SelectedIndex]];
                btnGo_Click(null, null);
            }
            else
            {
                MessageBox.Show("Can't go any more forward");
                first = false;
            }
        }
    }



}

