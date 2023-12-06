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

namespace DI_UT1_Ejemplo22_DisennoAdaptativo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> courses = new List<string>
            {
                "First", "Second", "Third", "Forth"
            };
            cmBYearC.ItemsSource = courses;
            cmbCurso.ItemsSource = courses;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(e.NewSize.Width <= 500)
            {
                ColumnView.Visibility = Visibility.Visible;
                TableView.Visibility = Visibility.Collapsed;
            }
            else
            {
                ColumnView.Visibility = Visibility.Collapsed;
                TableView.Visibility = Visibility.Visible;
            }
        }
    }
}
