using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary_lab_3;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            


            var vm = new MainWindowViewModel();


            this.DataContext = vm;

            
        }

        

        private void Result_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Height_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Square_1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Square_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }

}