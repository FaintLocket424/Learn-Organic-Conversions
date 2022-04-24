using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemistryOrganicMechanisms
{
    internal class Conversion
    {
        private readonly string _conversionName;
        private readonly string[] _conditions;
        private readonly Image _image;
        private readonly string _mechanism;
        private readonly string[] _reactants;

        public Conversion(string conversion, string[] reactants, string[] conditions, string mechanism, Image image)
        {
            _conversionName = conversion;
            _conditions = conditions;
            _image = image;
            _mechanism = mechanism;
            _reactants = reactants;
        }

        public string ConversionName { get => _conversionName; }
        public string[] Conditions { get => _conditions; }
        public Image Image { get => _image; }
        public string Mechanism { get => _mechanism; }
        public string[] Reactants { get => _reactants; }
    }
}
