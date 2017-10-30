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

namespace FirstApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();


            //DataGridPhone.ItemsSource = list;
            //int column = Grid.GetColumn(ButtonGetProperty);
            //int row = Grid.GetRow(ButtonGetProperty);
            //TextBlock block =  new TextBlock();
            //SetValue(TextBlock.TextProperty, "aaaa1111"); 
            //block.Text = "aaaaa";

            //SetValue(TextProperty, "aaa");
        }
    }
}
