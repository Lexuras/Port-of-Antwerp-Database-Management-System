using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXZAM_Haven.Business
{
    public class Product
    {
		private int _idProduct;

		public int idProduct
		{
			get { return _idProduct; }
			set { _idProduct = value; }
		}

		private string _Naam;

		public string Naam
		{
			get { return _Naam; }
			set { _Naam = value; }
		}

		private double _TotaalGewichtKG;

		public double TotaalGewichtKG
		{
			get { return _TotaalGewichtKG; }
			set { _TotaalGewichtKG = value; }
		}

		private string _TypeVerpakking;

		public string TypeVerpakking
		{
			get { return _TypeVerpakking; }
			set { _TypeVerpakking = value; }
		}

		public Product(int idProduct, string Naam, double TotaalGewichtKG, string TypeVerpakking)
		{
			_idProduct= idProduct;
			_Naam= Naam;	
			_TotaalGewichtKG= TotaalGewichtKG;
			_TypeVerpakking= TypeVerpakking;
		}
        public Product(string Naam, double TotaalGewichtKG, string TypeVerpakking)
        {
        
            _Naam = Naam;
            _TotaalGewichtKG = TotaalGewichtKG;
            _TypeVerpakking = TypeVerpakking;
        }

        public override string ToString()
        {
            return _idProduct + " - " + _Naam + " -Totaal KG:  " + _TotaalGewichtKG + " -Verpakking: "+ _TypeVerpakking;
        }
    }
}
