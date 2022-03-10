using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _firstValue;
        private string _secondValue;
        private string Operation;
        string A = "";
        public ReactiveCommand<string, string> Button_Click { get; }
        public ReactiveCommand<string, string> Calculate { get; }

    bool isDisplayingResult = false;
        public MainWindowViewModel()
        {
            AddNumberCommand = ReactiveCommand.Create<int>(AddNumber);

        }
    }

   
}
