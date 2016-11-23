﻿using GalaSoft.MvvmLight.Messaging;
using JumpStreetMobile.Shared.Messages;
using JumpStreetMobile.Shared.Model;
using JumpStreetMobile.XForms.View;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JumpStreetMobile.XForms
{
	public class App : Application
	{
        public App ()
		{
            // The root page of your application
            MainPage = new TodoListView();
        }

        protected override void OnStart ()
		{
            // Handle when your app starts

// Checks to see if conditional compliation symbol has be specifed when ModeOfOperations is set to OnlineOnly
#if !OnlineOnly
            if (ApplicationCapabilities.ModeOfOperation == ModeOfOperation.OnlineOnly)
                Messenger.Default.Send<ShowMessageDialog>(new ShowMessageDialog() { Title = "Configuration Error", Message = "When ModeOfOperation is set to OnlineOnly you must also specify the conditional compilation symbol OnlineOnly in the Build settings for the project" });
#endif

        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

