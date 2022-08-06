using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02.Senkronik_programlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text));

        }

        private async void btnCarp_Click(object sender, EventArgs e)
        {

           await CarpAsync(Convert.ToInt32(txtSayi1.Text), Convert.ToInt32(txtSayi2.Text));
        }
        public void Topla(int sayi1,int sayi2)
        {
            MessageBox.Show((sayi1+sayi2).ToString());

        }
       
        public Task CarpAsync(int sayi1,int sayi2)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(10000);
                MessageBox.Show((sayi1 * sayi2).ToString());
            });



        }
    }
}
