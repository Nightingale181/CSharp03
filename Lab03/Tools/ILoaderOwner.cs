using System.ComponentModel;

namespace Lab03.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        bool IsControlEnabled { get; set; }
    }
}
