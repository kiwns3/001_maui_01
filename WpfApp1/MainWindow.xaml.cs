using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_02_bmi
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private double weight = 70;
        private double height = 150;
        private const double Step = 1.0;  //상수 필드 또는 지역 상수를 선언할 때

        public double Height
        {
            get => height;
            set
            {
                height = NextStep(value);
                UpdateBMI();
            }
        }
        public double Weight
        {
            get => weight;
            set
            {
                height = NextStep(value);
                UpdateBMI();
            }
        }
        public double Bmi
            => Math.Round(Weight / Math.Pow(Height / 100, 2), 2);

        public string Classification
        {
            get
            {
                if (Bmi < 18.5)
                    return "당신은 저체중입니다.";
                else if (Bmi < 25)
                    return "당신은 정상체중입니다";
                else if (Bmi < 30)
                    return "당신은 과체중입니다.";
                else
                    return "당신은 비만입니다.";
            }
        }

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        private void UpdateBMI()
        {
            RaisePropertyChanged(nameof(Bmi));
            RaisePropertyChanged(nameof(Classification));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
        private double NextStep(double value)
            => Math.Round(value / Step) * Step;
    }
}



namespace Maui_02_bmi;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel();
    }
}