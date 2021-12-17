using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingXam.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Binding : ContentPage
    {
        public Binding()
        {
            InitializeComponent();

            Person person = new Person { FirstName = "Peter", SurName = "Walker", Age = 35 };

            BindingContext = person;
         
        }
    }
}