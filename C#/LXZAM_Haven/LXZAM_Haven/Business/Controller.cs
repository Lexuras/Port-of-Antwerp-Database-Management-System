using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXZAM_Haven.Business
{
    public class Controller
    {
        private Persistence.Persistence _persistence;
        private Overzicht _overzicht;
        public Controller()
        {
            _persistence = new Persistence.Persistence();
            _overzicht = new Overzicht();
            
        }

        //

        //methodes
        public List<Product> getProducten()
        {
            return _persistence.ToonProducten();
        }
        public List<Haven> GetHavens()

        {
            return _persistence.ToonHavens();
        }

        public List<Schip> GetSchip()
        {
            return _persistence.ToonSchepen();
        }
        //toevoeg query
        public void SchipToevoegen(Schip s)
        {
            _persistence.SchipToevoegen(s);
        }

        public void HavenToevoegen(Haven h)
        {
            _persistence.HavenToevoegen(h);
        }

        public void ProductToevoegen(Product p )
        {
            _persistence.ProductToevoeg(p);
        }

        //delete query

        public void SchipVerwijderen(Schip s)
        {
            _persistence.SchipVerwijderen(s);
        }

        public void HavenVerwijderen(Haven h)
        {
            _persistence.HavenVerwijderen(h);
        }

        public void ProductVerwijderen(Product p)
        {
            _persistence.ProductVerwijderen(p);
        }
        //verander querry
        public void HavenVeranderen(Haven h)
        {
            _persistence.HavenVeranderen(h);
        }

        public void SchipVeranderen(Schip s)
        {
            _persistence.SchipVeranderen(s);
        }
        public void ProductVeranderen(Product p)
        {
            _persistence.ProductVeranderen(p);
        }

        //extra query /class
        public List<Route> GetRoutes()
        {
            return _persistence.ToonRoutes();
        }

        public List<ProductPerRoute> GetProductenPerRoutes()
        {
            return _persistence.ToonProductenPerRoutes();
        }
    }
}
