using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace inherit
{
    /// <summary>
    /// Interaction logic for refout.xaml
    /// </summary>
    public partial class refout : Window
    {
        public refout()
        {
            InitializeComponent();
        }
        int shipping = 0;
        int tax = 2;
        int total;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
             int pr = Convert.ToInt32(txtprice.Text);
             int qty = Convert.ToInt32(txtqnty.Text);
             string name = txtname.Text;
            //string pname = "Pen";
            //int pr = 20;
        
             Bill(pr,qty,ref shipping,in tax ,out total);
            // MessageBox.Show(res.ToString());
            MessageBox.Show("Name :" + txtname.Text + "\n" + "Price :" + pr + "\n" + "Quantity :" + qty + "\n" + "Shipping :" + shipping + "\n"+ "Tax :" + tax + "\n" + "\n" + "\n" + "Total :" + total);
            
        }
        public void Bill(int price, int quantity,ref int shipping,in int tax, out int total)
        {
           // tax += 1;
            shipping += 10;
            total = (quantity * price)+shipping + tax;
           // return total;
          
        }

        
    }
   
}
