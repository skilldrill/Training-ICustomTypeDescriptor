using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Collections;
using System.Reflection;

namespace TestCustomProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += this.Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            MyClass c = new MyClass();
            c.AddProperty("hello","world");
            c.AddProperty("testint", 2);                     
            propertyGrid.SelectedObject = c;
        }
    }
}
