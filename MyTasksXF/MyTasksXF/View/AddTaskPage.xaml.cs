﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTasksXF.View {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTaskPage : ContentPage {
        public AddTaskPage() {
            InitializeComponent();
        }

        private void CloseModal(object sender, EventArgs e) {
            Navigation.PopModalAsync();
        }
    }
}