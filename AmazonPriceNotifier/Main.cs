using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazonPriceNotifier
{
    public partial class Main : Form
    {
        PriceNotifier notifier;

        string amazonLink = "";
        public Main()
        {
            InitializeComponent();

        }

        private void BtnPrice_Click(object sender, EventArgs e)
        {
           amazonLink = txtBoxLink.Text;
           

           notifier = new PriceNotifier(amazonLink);

           labelTitle.Text = notifier.title;
           labelPrice.Text = notifier.price;
        }

        private void TxtBoxLink_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
