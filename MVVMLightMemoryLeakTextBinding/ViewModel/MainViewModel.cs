using System;

using GalaSoft.MvvmLight;

namespace MVVMLightMemoryLeakTextBinding.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private String myBinding;
        public String MyBinding
        {
            get { return this.myBinding; }
            set
            {
                this.myBinding = value;
                this.RaisePropertyChanged("MyBinding");
            }
        }

        public MainViewModel()
        {
            this.MyBinding = "It works!";
        }
    }
}