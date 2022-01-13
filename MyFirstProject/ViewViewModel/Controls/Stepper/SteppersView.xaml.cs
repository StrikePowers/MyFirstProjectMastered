using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.Stepper
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SteppersView : ContentPage
    {
        public SteppersView()
        {
            InitializeComponent();
            BindingContext = new SteppersViewModel();
        }
    }
}