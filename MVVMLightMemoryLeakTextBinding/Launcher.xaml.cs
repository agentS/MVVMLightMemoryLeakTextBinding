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

namespace MVVMLightMemoryLeakTextBinding
{
    /// <summary>
    /// Interaction logic for Launcher.xaml
    /// </summary>
    public partial class Launcher : Window
    {
        private Window mvvmWindow;

        public Launcher()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.mvvmWindow != null)
            {
                this.mvvmWindow.Close();
            }

            this.mvvmWindow = new MVVMWindow();
            this.mvvmWindow.Closed += this.CleanupMVVMWindow;
            this.mvvmWindow.Show();
        }

        private void CleanupMVVMWindow(Object sender, EventArgs e)
        {
            this.mvvmWindow.Closed -= this.CleanupMVVMWindow;
            this.mvvmWindow = null;

            GC.Collect();
            GC.WaitForFullGCComplete();
        }
    }
}
