using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Wincubate.DataBindingCollectionsExamples.Data
{
    public class Module
    {
        public string Title
        {
            get;
            set;
        }

        public ObservableCollection<Slide> Slides { get => _slides; }
        private readonly ObservableCollection<Slide> _slides;

        public Module()
        {
            #region Set random slide numbers

            int j = 1;
            _slides = new ObservableCollection<Slide>();
            for (int i = 0; i < 5; i++)
            {
                _slides.Add(new Slide());
            }

            
            #endregion
        }
    }
}
