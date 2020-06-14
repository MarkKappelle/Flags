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


        string json = @"{""key1"":""value1"",""key2"":""value2""}";
        Dictionary<string, string> values = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);


        public void DisplayFlag(String code)
        {
            Image flag = Image.FromFile($".\\country-flags-master\\png250px\\{code}.png");
            flagBoxOne.Image = flag;
            flagBoxOne.Width = flag.Width;
            flagBoxOne.Height = flag.Height;

        }


        private void flagBoxOne_Click(object sender, EventArgs e)
        {
            Image flag = Image.FromFile(@".\country-flags-master\png250px\nl.png");
            flagBoxOne.Image = flag;
            flagBoxOne.Width = flag.Width;
            flagBoxOne.Height = flag.Height;
        }

        private void Testclick(object sender, EventArgs e)
        {
            String code = "es";
            DisplayFlag(code);
        }
    }
}
