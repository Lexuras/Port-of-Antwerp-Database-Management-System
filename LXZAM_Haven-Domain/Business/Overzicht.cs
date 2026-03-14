using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXZAM_Haven.Business
{
    internal class Overzicht
    {
        private List<Haven> _Havens;
        private List<Schip> _Schepen;
        private List<Product> _Producten;
        private List<Route> _Routes;

        public List<Route> Routes
        {
            get { return _Routes; }
            set { _Routes = value; }
        }

        private List<ProductPerRoute> _ProductenPerRoutes;

        public List<ProductPerRoute> ProductenPerRoutes
        {
            get { return _ProductenPerRoutes; }
            set { _ProductenPerRoutes = value; }
        }

        public List<Product> Producten
        {
            get { return _Producten; }
            set { _Producten = value; }
        }
        public List<Haven> Havens
        {
            get { return _Havens; }
            set { _Havens = value; }
        }

        public List<Schip> Schepen
        {
            get { return _Schepen; }
            set { _Schepen = value; }
        }

        public Overzicht()
        {
            _Havens = new List<Haven>();
            _Schepen = new List<Schip>();
            _Producten = new List<Product>();
            _Routes = new List<Route>();
            _ProductenPerRoutes = new List<ProductPerRoute>();
        } 
    }
}
