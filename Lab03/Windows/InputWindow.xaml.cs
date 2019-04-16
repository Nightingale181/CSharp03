using Lab03.ViewModels;
using System;
using System.Windows.Controls;

namespace Lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class InputWindow : UserControl
    {
             public InputWindow()
        {
                InitializeComponent();
                DataContext = new InputViewModel();

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
