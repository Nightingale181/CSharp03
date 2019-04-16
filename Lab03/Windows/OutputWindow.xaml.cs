using Lab03.Model;
using Lab03.Tools.Meneger;
using Lab03.ViewModels;
using System;
using System.ComponentModel;
using System.Windows;

namespace Lab03
{
    /// <summary>
    /// Interaction logic for OutputWindow.xaml
    /// </summary>
    public partial class OutputWindow : Window
    {
        public string ViewModel { get; set; }

        public OutputWindow(Person person)
        {
            InitializeComponent();
            OutputViewModel model = new OutputViewModel(person);
            this.DataContext = model;
            if (model.CloseAction == null)
                model.CloseAction = new Action(() => this.Close());
            this.Closing += Window_Closing;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            LoaderManeger.Instance.HideLoader();
        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }
    }
}
