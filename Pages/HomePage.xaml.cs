﻿using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using TwogapWallet.Core.ViewModels;
using Xamarin.Forms;

namespace TwogapWallet.UI.Pages
{
    public partial class HomePage : MvxContentPage<HomeViewModel>
    {
        public HomePage()
        {
            InitializeComponent();
        }
    }
}
