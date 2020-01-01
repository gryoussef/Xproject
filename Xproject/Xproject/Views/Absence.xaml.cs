﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xproject.ViewModels;

namespace Xproject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Absence : ContentPage
    {
        AbsenceViewModel AbsenceVM;
        public Absence()
        {
            InitializeComponent();
            AbsenceVM = new AbsenceViewModel();
            this.BindingContext = AbsenceVM;
        }
    }
}