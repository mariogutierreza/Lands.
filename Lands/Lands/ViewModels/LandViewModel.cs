namespace Lands.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Models;

    public class LandViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Border> borders;
        private ObservableCollection<Currency> currencies;
        private ObservableCollection<Lenguage> lenguages;
        #endregion

        #region Properties
        public Land Land
        {
            get;
            set;
        }
        public ObservableCollection<Border> Borders
        {
            get { return this.borders; }
            set { this.SetValue(ref this.borders, value); }
        }

        public ObservableCollection<Currency> Currencies
        {
            get { return this.currencies; }
            set { this.SetValue(ref this.currencies, value); }
        }
        public ObservableCollection<Lenguage> Lenguages
        {
            get { return this.lenguages; }
            set { this.SetValue(ref this.lenguages, value); }
        }
        #endregion

        #region Constructors
        public LandViewModel(Land land)
        {
            this.Land = land;
            this.loadBorders();
            this.currencies = new ObservableCollection<Currency>(this.Land.Currencies);
            this.Lenguages = new ObservableCollection<Lenguage>(this.Land.Languages);
        }
        #endregion

        #region Methods
        private void loadBorders()
        {
            this.Borders = new ObservableCollection<Border>();
            foreach (var border in this.Land.Borders)
            {
                var land = MainViewModel.GetInstance().LandsList.
                                        Where(l => l.Alpha3Code == border).
                                        FirstOrDefault();
                if (land != null)
                {
                    this.Borders.Add(new Border
                    {
                        Code = land.Alpha3Code,
                        Name = land.Name,
                    });
                }
            }
        } 
        #endregion
    }
}
