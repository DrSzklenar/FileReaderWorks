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
using System.Xml;
using System.Xml.Linq;


namespace FileReader
{

    public partial class Listing : Form
    {
        public string SourceFile;
        public string DestinationFile;

        public Dictionary<string, string> adatok = new Dictionary<string, string>();

        public static XElement items;
        public static XElement itemsnew;

        public Listing(string fromFileName, string toFileName)
        {
            InitializeComponent();
            SourceFile = fromFileName;
            DestinationFile = toFileName;

            FillDictionary();
            FillLbLanguage();

            DoEverything();
        }

        private void DoEverything()
        {
            items = XElement.Load((@"items.xml"));
            itemsnew = items;
            int ii = 0;
            foreach (var row in items.Descendants())
            {
                
                if (!Convert.ToString(row).Contains("name=") && !Convert.ToString(row).Contains("desctiption="))
                {

                }
                else
                {
                    if (row.Attribute("name").Value == adatok.ElementAt(ii).Key && row.Attribute("description").Value == adatok.ElementAt(ii + 1).Key)
                    {
                        row.Attribute("name").Value = adatok.ElementAt(ii).Value;
                        row.Attribute("description").Value = adatok.ElementAt(ii + 1).Value;
                    }
                    else
                    {
                        for (int i = 0; i < adatok.Count; i++)
                        {
                            if (row.Attribute("name").Value == adatok.ElementAt(i).Key)
                            {
                                row.Attribute("name").Value = adatok.ElementAt(i).Value;
                            }
                            if (row.Attribute("description") != null)
                            {
                                if (row.Attribute("description").Value == adatok.ElementAt(i).Key)
                                {
                                    row.Attribute("description").Value = adatok.ElementAt(i).Value;
                                }
                            }
                        }
                    }
                    ii++;
                lbItems.Items.Add(row);
                }
            }
        }

        private void FillDictionary()
        {
            using (StreamReader sr = new StreamReader(SourceFile))
            {
                string temp;
                string temp2;

                for (int i = 0; i < 1348; i++)
                {
                    sr.ReadLine();
                }
                while (!sr.EndOfStream)
                {
                    temp = sr.ReadLine();
                    if (temp.Contains("category"))
                    {
                        break;
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        sr.ReadLine();
                    }
                    temp2 = sr.ReadLine();
                    temp = temp.Remove(0, 15);
                    temp = temp.Replace("\">", "");
                    temp2 = temp2.Remove(0, 14);
                    temp2 = temp2.Replace("</string>", "");
                    temp = temp.Insert(0, "#");
                    if (temp2 != "kakizos")
                    {
                        adatok.Add(temp, temp2);
                    }
                    sr.ReadLine();
                }
            }
        }

        private void FillLbLanguage()
        {
            foreach (var adat in adatok)
            {
                lbLanguage.Items.Add(adat.Key);
                lbLanguage.Items.Add(adat.Value);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "XML|*.xml";
            saveFileDialog1.Title = "Save an File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                itemsnew.Save(saveFileDialog1.FileName);
            }
        }
    }
}
