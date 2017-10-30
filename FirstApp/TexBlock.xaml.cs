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
    /// Логика взаимодействия для TexBlock.xaml
    /// </summary>
    public partial class TexBlock
    {
        public TexBlock()
        {
            InitializeComponent();
        }

        private Phone _message;
        public Phone Message
        {
            get { return (Phone)GetValue(TestMessage); }
            set { SetValue(TestMessage, value); }
        }


        public static readonly DependencyProperty TestMessage =
            DependencyProperty.Register("Message", typeof(Phone),
                typeof(TexBlock), new UIPropertyMetadata(Callback));

        private static void Callback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var sender = d as TexBlock;
            MessageBox.Show(sender.Message.Price.ToString());
        }
    }
}
