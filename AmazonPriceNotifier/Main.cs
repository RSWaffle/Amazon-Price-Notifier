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
        public Main()
        {
            notifier = new PriceNotifier();
            InitializeComponent();

            label1.Text = notifier.price;
        }
    }
}
