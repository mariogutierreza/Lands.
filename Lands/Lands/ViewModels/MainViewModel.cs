﻿namespace Lands.ViewModels
{

    using System.Collections.Generic;
    using Models;
    public class MainViewModel
    {
        #region ViewModels

        #region Properties
        public List<Land> LandsList

        {
            get;
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
    }


}
