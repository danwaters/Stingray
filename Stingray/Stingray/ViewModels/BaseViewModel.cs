using System;
using Xamarin.Forms;

namespace Stingray.ViewModels
{
    public class BaseViewModel : BindableObject
    {
        private bool isBusy;
        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
    }

    public class Busy : IDisposable
    {
        private BaseViewModel viewModel;

        public Busy(BaseViewModel model)
        {
            viewModel = model;
            viewModel.IsBusy = true;
        }

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    viewModel.IsBusy = false;
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
