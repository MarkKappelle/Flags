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
using Newtonsoft.Json;

namespace Flags
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        static string json = File.ReadAllText(@"..\..\country-flags-master/countries.json");
        static Dictionary<string, string> country_codes = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

        List<string> country_png = country_codes.Keys.ToList();
        List<string> country_name = country_codes.Values.ToList();

        ComboBox CountryBox = new ComboBox();



        private void form_load(object sender, EventArgs e)
        {
            
            Controls.Add(CountryBox);
            CountryBox.Location = new System.Drawing.Point(12, 36);
            CountryBox.Width = 200;
            foreach (string element in country_name)
            {
                CountryBox.Items.Add(element);  
            }
            CountryBox.SelectedIndexChanged += new System.EventHandler(CountryBox_SelectedIndexChanged);
        }

        private void CountryBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            DisplayFlag(CountryToCode(CountryBox.Text));
             
        }



        public void DisplayFlag(String code)
        {
            Image flag = Image.FromFile($"..\\..\\country-flags-master\\png250px\\{code}.png");
            flagBoxOne.Image = flag;
            flagBoxOne.Width = flag.Width;
            flagBoxOne.Height = flag.Height;

        }

        public string CountryToCode(string country)
        {
            int i = country_name.IndexOf(country);
            return country_png[i];
        }


        private void flagBoxOne_Click(object sender, EventArgs e)
        {
            Image flag = Image.FromFile(@"..\..\country-flags-master\png250px\nl.png");
            flagBoxOne.Image = flag;
            flagBoxOne.Width = flag.Width;
            flagBoxOne.Height = flag.Height;
        }

        private void Testclick(object sender, EventArgs e)
        {
            String code = "es";
            DisplayFlag(code);
            textBox1.Text = (country_name.Count).ToString();
        }

        
    }
}
