using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FirstApp
{
    public class UserControl1 :UserControl
    {
        public static DependencyProperty TxtBoxValueProperty = DependencyProperty.Register("TxtBoxValue", typeof(String), typeof(UserControl1));

        public String TxtBoxValue
        {
            get { return (String)GetValue(TxtBoxValueProperty); }
            set
            {
                SetValue(TxtBoxValueProperty, value);
            }
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property == TxtBoxValueProperty)
            {
                // Do whatever you want with it
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
