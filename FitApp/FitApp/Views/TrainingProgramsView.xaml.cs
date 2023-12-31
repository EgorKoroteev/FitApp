﻿using FitApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FitApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingProgramsView : ContentPage
    {
        private TrainingProgramsViewModel _viewModel;
        public TrainingProgramsView()
        {
            InitializeComponent();

            BindingContext = _viewModel = new TrainingProgramsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.ExecuteLoadTrainingProgramsCommand();
        }
    }
}