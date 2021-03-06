﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTasksXF.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage {
        public HomePage() {
            InitializeComponent();
        }

        private void ShowAddPage(object sender, EventArgs e) {
            Navigation.PushModalAsync(new AddTaskPage());
        }
    }
}