using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CarouselView.FormsPlugin.Abstractions;
using MvvmCross.Forms.Bindings;
using MvvmCross.Forms.Views;
using TwogapWallet.Core.ViewModels;
using Xamarin.Forms;

namespace TwogapWallet.UI.Pages
{
    [MvvmCross.Forms.Presenters.Attributes.MvxNavigationPagePresentation(WrapInNavigationPage = false)]
    public partial class SliderPicturePage : MvxContentPage<SliderPictureViewModel>
    {
        

                    public SliderPicturePage()
                    {
                        InitializeComponent();


           

        }

       
    }
}
