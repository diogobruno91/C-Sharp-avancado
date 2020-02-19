using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace _42_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //REDE, ARMAZENAMENTO, TELA/DISPLAY.
        private async void btnBaixar_Click(object sender, EventArgs e)
        {
            //TASK - Asynchrono (Thread).
            string endereco = txtSite.Text;

            WebClient web = new WebClient();
           // string html = web.DownloadString(endereco);
            
            string html = await web.DownloadStringTaskAsync(new Uri(endereco));

            txtResultado.Text = html;

        }
    }
}
