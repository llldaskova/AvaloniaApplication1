using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _firstValue="";
        private string _secondValue="";
        private string Operation="";
        string a = "";
        
        public ReactiveCommand<Unit, string> Button_Click{ get; }
        public ReactiveCommand<Unit, string> Button_Click2 { get; }
        public ReactiveCommand<Unit, string> Button_Click3 { get; }
        public ReactiveCommand<Unit, string> Button_Click4 { get; }
        public ReactiveCommand<Unit, string> Button_Click5 { get; }
        public ReactiveCommand<Unit, string> Button_Click6 { get; }
        public ReactiveCommand<Unit, string> Button_Click7 { get; }
        public ReactiveCommand<Unit, string> Button_Click8 { get; }
        public ReactiveCommand<Unit, string> Button_Click9 { get; }
        public ReactiveCommand<Unit, string> Button_Click10 { get; }
        public ReactiveCommand<Unit, string> Button_Click11 { get; }
        public ReactiveCommand<Unit, string> Button_Click12 { get; }

        public MainWindowViewModel()
        {
            Button_Click = ReactiveCommand.Create(() => A += "I") ;

        }

        public string A
        {
            set
            {
                this.RaiseAndSetIfChanged(ref a, value);
            }
            get
            {
                return this.a;
            }
        }
    }

   
}
