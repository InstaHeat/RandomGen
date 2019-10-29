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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RandomGenerator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<int> numbers = new List<int>();

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Random rand = new Random();
                //
                int min = Convert.ToInt32(tbxMin.Text);
                int max = Convert.ToInt32(tbxMax.Text);

                int val = rand.Next(min, max);
                //Result
                tbxResult.Text = Convert.ToString(val);
                //To listbox
                listBox.Items.Add(tbxResult.Text);
            }

            catch
            {
                MessageBox.Show("Please enter valid values min and max!", "Error occured",MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

    }
}
