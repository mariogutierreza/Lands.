﻿namespace Lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Models;
    using Helpers;

    public class MainViewModel
    {
        #region ViewModels

        #region Properties
        public List<Land> LandsList

        {
            get;
            set;
        }

        public string Token { get; set; }

        public string TokenType { get; set; }

        public ObservableCollection<MenuItemViewModel> Menus
            
            
            { get;
              set;
            }
        #endregion

        public LoginViewModel Login
        {
            get;
            set;
        }

        public LandsViewModel Lands
        {
            get;
            set;
        }

        public LandViewModel Land

        {
            get;
            set;
        }
        #endregion

        #region Constructors

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
            this.LoadMenu();
            
        }

        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion

        #region Methods
        private void LoadMenu()
        {
            this.Menus = new ObservableCollection<MenuItemViewModel>();
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_settings",
                PageName= "MyProfile",
                Title=Languages.MyProfile
            });
            this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_insert_chart",
                PageName = "StaticsPage",
                Title = Languages.Statics
            }); this.Menus.Add(new MenuItemViewModel
            {
                Icon = "ic_exit_to_app",
                PageName = "LoginPage",
                Title = Languages.LogOut
            });
        } 
        #endregion
    }


}
