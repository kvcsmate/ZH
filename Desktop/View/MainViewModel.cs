using Desktop.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Desktop.View
{
    public class MainViewModel:ViewModelBase
    {
        private readonly ApiServiceClient _service;

        public event EventHandler LogoutSucceeded;

        public DelegateCommand LogoutCommand { get; private set; }

        public MainViewModel(ApiServiceClient serviceClient)
        {
            _service = serviceClient;
            LogoutCommand = new DelegateCommand(_ => LogoutAsync());
        }

        private async void LogoutAsync()
        {
            try
            {
                await _service.LogoutAsync();
                LogoutSucceeded?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex) when (ex is NetworkException || ex is HttpRequestException)
            {
                OnMessageApplication($"Unexpected error occured! ({ex.Message})");
            }
        }
    }
}
