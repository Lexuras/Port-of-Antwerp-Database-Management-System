using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXZAM_Haven.Business
{
    public class Haven
    {
        private int _idHaven;

        public int idHaven
        {
            get { return _idHaven; }
            set { _idHaven = value; }
        }

        private string _Naam;

        public string Naam
        {
            get { return _Naam; }
            set { _Naam = value; }
        }

        private string _Land;

        public string Land
        {
            get { return _Land; }
            set { _Land = value; }
        }

        private string _Stad;

        public string Stad
        {
            get { return _Stad; }
            set { _Stad = value; }
        }

        private int _aantalDokken;

        public int aantalDokken
        {
            get { return _aantalDokken; }
            set { _aantalDokken = value; }
        }

        public Haven(int idHaven, string naam, string land, string stad,int aantalDokken)
        {
            _Stad= stad;
            _Naam= naam;
            _Land= land;
            _idHaven= idHaven;
            _aantalDokken= aantalDokken;
        }

        public Haven( string naam, string land, string stad, int aantalDokken)
        {
            _Stad = stad;
            _Naam = naam;
            _Land = land;
            _aantalDokken = aantalDokken;
        }

        public override string ToString()
        {

            return _Naam + " met als land: " + _Land + " in de stad "  + _Stad + " -- aantaldokken: " +  _aantalDokken;
        }
    }
}
