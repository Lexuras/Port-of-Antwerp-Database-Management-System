using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXZAM_Haven.Business
{
    public class Schip
    {
		private int _idSchip;

		public int idSchip
		{
			get { return _idSchip; }
			set { _idSchip = value; }
		}

		private string _Naam;

		public string Naam
		{
			get { return _Naam; }
			set { _Naam = value; }
		}

		private string _Type;

		public string Type
		{
			get { return _Type; }
			set { _Type = value; }
		}

		private double _Lengte;

		public double Lengte
		{
			get { return _Lengte; }
			set { _Lengte = value; }
		}

		private double _Breedte;

		public double Breedte
		{
			get { return _Breedte; }
			set { _Breedte = value; }
		}

		private int _Capaciteit;

		public int Capaciteit
		{
			get { return _Capaciteit; }
			set { _Capaciteit = value; }
		}

		//

		public Schip(int idSchip, string Naam, string Type, double Lengte, double Breedte, int Capaciteit)
		{
			_idSchip = idSchip;
			_Naam = Naam;	
			_Type = Type;	
			_Lengte = Lengte;	
			_Breedte = Breedte;	
			_Capaciteit = Capaciteit;

		}

        public Schip( string Naam, string Type, double Lengte, double Breedte, int Capaciteit)
        {
         
            _Naam = Naam;
            _Type = Type;
            _Lengte = Lengte;
            _Breedte = Breedte;
            _Capaciteit = Capaciteit;

        }

        public override string ToString()
        {

            return _idSchip + " -- " + _Naam + " -- " + _Type + " --Lengte: " + _Lengte + " --Breedte: " + _Breedte + " --Capaciteit: " +  _Capaciteit;
        }




    }
}
