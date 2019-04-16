using Lab03.Tools;
using Lab03.Tools.Meneger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab03.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel, ILoaderOwner
    {
        private bool _isControlEnabled = true;

        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }

        public Visibility LoaderVisibility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        internal MainWindowViewModel()
        {
            LoaderManeger.Instance.Initialize(this);
        }

    }
}
