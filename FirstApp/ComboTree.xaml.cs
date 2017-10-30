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

namespace FirstApp
{
    /// <summary>
    /// Логика взаимодействия для ComboTree.xaml
    /// </summary>
    public partial class ComboTree
    {
        public ComboTree()
        {
            InitializeComponent();
        }

        protected override void OnSelectedItemChanged(RoutedPropertyChangedEventArgs<object> e)
        {
            MySelectedItem = e.NewValue as SuperNode;
            base.OnSelectedItemChanged(e);
        }

        public static readonly DependencyProperty MySelectedItemProperty =
            DependencyProperty.Register("MySelectedItem", typeof(SuperNode), typeof(ComboTree), new UIPropertyMetadata(Callback));

        private static void Callback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sender = d as ComboTree;
            //(sender.DataContext as MainViewModel).Nodes[0]=(e.NewValue as SuperNode);
            (sender.DataContext as MainViewModel).SelectNodeTreeView = e.NewValue as SuperNode;
        }

        private SuperNode _mySelectedItem;
        public SuperNode MySelectedItem
        {
            get { return (SuperNode)GetValue(MySelectedItemProperty); }
            set { SetValue(MySelectedItemProperty, value); }
        }
    }
}
