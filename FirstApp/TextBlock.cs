
using System;
using System.Windows;
using System.Windows.Controls;

namespace FirstApp
{
    public class TextBlock : FrameworkElement
    {
        public static readonly DependencyProperty TextProperty;
        static TextBlock()
        {
            TextProperty = DependencyProperty.Register("Text", typeof(string),
                typeof(TextBlock), new PropertyMetadata(0));
        }

        public TextBlock()
        {
            
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
            
    }
}
