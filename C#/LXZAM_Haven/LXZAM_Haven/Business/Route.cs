using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXZAM_Haven.Business
{
    public class Route
    {
        public int idRoute
        {
            get { return _idRoute; }
            set { _idRoute = value; }
        }

        private int _idSchip;

		public int idSchip
		{
			get { return _idSchip; }
			set { _idSchip = value; }
		}

		private int _idHaven;

		public int idHaven
		{
			get { return _idHaven; }
			set { _idHaven = value; }
		}

		private int _idRoute;

		

		private DateTime _VertrekDatum;

		public DateTime VertrekDatum
		{
			get { return _VertrekDatum; }
			set { _VertrekDatum = value; }
		}

		private DateTime _AankomstDatum;

		public DateTime AankomstDatum
		{
			get { return _AankomstDatum; }
			set { _AankomstDatum = value; }
		}

		private double _AfstandKM;

		public double AfstandKM
		{
			get { return _AfstandKM; }
			set { _AfstandKM = value; }
		}

		public Route(int idRoute, int idSchip, int idHaven,  DateTime VertrekDatum, DateTime AankomstDatum, double AfstandKM)
		{
			_idRoute= idRoute;
			_idSchip= idSchip;	
			_idHaven= idHaven;
			_VertrekDatum= VertrekDatum;
			_AankomstDatum= AankomstDatum;
			_AfstandKM= AfstandKM; 
		}

        public Route(int idSchip, int idHaven, DateTime VertrekDatum, DateTime AankomstDatum, double AfstandKM)
        {

            _idSchip = idSchip;
            _idHaven = idHaven;
            _VertrekDatum = VertrekDatum;
            _AankomstDatum = AankomstDatum;
            _AfstandKM = AfstandKM;
        }

        public override string ToString()
        {
			return "| Route ID: " + _idRoute + " | Schip ID: " + _idSchip + " | Haven ID: " + _idHaven + " | Vertrekdatum: " + _VertrekDatum + " | AankomstDatum: " + _AankomstDatum + " | AfstandKM: " + _AfstandKM;
        }


    }
}
