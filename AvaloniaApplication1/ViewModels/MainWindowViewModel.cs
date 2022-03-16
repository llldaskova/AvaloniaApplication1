using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using AvaloniaApplication1.Models;
namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        RomanNumberExtend firtValue;
        RomanNumberExtend secondValue;
        string SecondValue = "";
        private string Operation="";
        string a = "";
        string b = "";
        string operation;
        int flag = 0;
        public ReactiveCommand<string, string> Button_Click{ get;  }
        public ReactiveCommand<string, string> Button_Click2 { get; }
        public ReactiveCommand<string, string> Button_Click3 { get; }

        public MainWindowViewModel()
        {
            Button_Click = ReactiveCommand.Create<string,string>(( str) =>
            {
                if(flag==1)
                {
                    SecondValue += str;
                }
                else if (flag==2)
                {
                    flag = 0;
                    A = "";
                }
                return A += str;
            } );
            Button_Click2 = ReactiveCommand.Create<string, string>((str) =>
            {
                if (flag == 0)
                    firtValue = new RomanNumberExtend(A);
                else
                {
                    throw new RomanNumberException();
                }
                operation = str;
                flag++;
                return A += str;
            });
            Button_Click3 = ReactiveCommand.Create<string,string>((str) =>
            {
                A += str;
                secondValue = new RomanNumberExtend(SecondValue);
                RomanNumber calc;
                if (operation=="+")
                {
                     calc = firtValue + secondValue;
                }
                else if (operation == "-")
                {
                    calc = firtValue - secondValue;
                }
                else if (operation == "/")
                {
                     calc = firtValue / secondValue;
                }
                else if (operation == "*")
                {
                     calc = firtValue * secondValue;
                }
                else
                {
                    throw new RomanNumberException();
                }
                flag++;
                SecondValue = "";
                return A = calc.ToString();
            });
        }

        public string A
        {
            set
            {
                this.RaiseAndSetIfChanged(ref a, value);
            }
            get
            {
                return a;
            }
        }
    }

   
}
