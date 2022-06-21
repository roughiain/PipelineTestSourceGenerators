using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using TestPipeline.Models;
using TestPipeline.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TestPipeline.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        [ObservableProperty]
        private bool isBusy = false;

        [ObservableProperty]
        private string title = string.Empty;
      
    }
}

