using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GUI_PresentationLayer.Models
{
    public class PopulationData
    {
        private string _name;
        private double _population;
        
        public PopulationData(string name, double population)
        {
            _name = name;
            _population = population;
        }

        public string NameItem
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public double Population
        {
            get => _population;
            set => _population = value;
        }
    }
}
