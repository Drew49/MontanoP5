using System;
using System.Collections.Generic;
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

namespace MontanoP5
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        private List<Sprocket> sprockets = new List<Sprocket>();

        public SprocketForm(Sprocket sprock)
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (cmbxItemType.SelectedIndex == 0)
            {
                SteelSprocket sprock = new SteelSprocket();
                sprock.ItemID = int.Parse(txbItemId.Text);
                sprock.NumOfItems = int.Parse(txbNumOfItems.Text);
                sprock.NumOfTeeth = int.Parse(txbNumOfTeeth.Text);
                txbRe
            }
            else if (cmbxItemType.SelectedIndex == 1)
            {
                AluminumSprocket sprock;
                sprock.ItemID = int.Parse(txbItemId.Text);
                sprock.NumOfItems = int.Parse(txbNumOfItems.Text);
                sprock.NumOfTeeth = int.Parse(txbNumOfTeeth.Text);
            }
        }
    }
}
