using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXZAM_Haven.Business
{
    public class ProductPerRoute
    {
		private int _idProduct;

		public int idProduct
		{
			get { return _idProduct; }
			set { _idProduct = value; }
		}

		private int _idRoute;

		public int idRoute
		{
			get { return _idRoute; }
			set { _idRoute = value; }
		}

		private int _AantalProduct;

		public int AantalProduct
		{
			get { return _AantalProduct; }
			set { _AantalProduct = value; }
		}

		public ProductPerRoute( int idRoute, int idProduct, int AantalProduct)
		{
            _idRoute = idRoute;
            _idProduct = idProduct;
			_AantalProduct= AantalProduct;
		}

        public override string ToString()
        {
			return " | Product ID: " + _idProduct + " | Route ID: " + _idRoute + " | Aantal producten: " + _AantalProduct;
        }



    }
}
