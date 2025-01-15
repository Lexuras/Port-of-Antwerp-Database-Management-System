using LXZAM_Haven.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LXZAM_Haven.Persistence
{
    internal class Persistence
    {

        private string _connectionstring;
        
        public Persistence()
        {
            _connectionstring = "server = localhost; database= LXZAM_Haven; user id = root; password="; //password:LaboSji123BE!
        }

        //methode 1 

        public List<Haven> ToonHavens()
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);
            MySqlCommand cmdToonHavens = new MySqlCommand("SELECT * FROM Haven ", cnnLXZAM_Haven);
            cnnLXZAM_Haven.Open();

            MySqlDataReader dtr = cmdToonHavens.ExecuteReader();
            List<Haven> lijst = new List<Haven>();
            while (dtr.Read())
            {
                Haven h = new Haven(
                    Convert.ToInt32(dtr["idhaven"]),
                    Convert.ToString(dtr["naam"]),
                    Convert.ToString(dtr["land"]),
                    Convert.ToString(dtr["stad"]),
                    Convert.ToInt32(dtr["aantalDokken"]));
                lijst.Add(h);
            }

            cnnLXZAM_Haven.Close();
            return lijst;
            
        }
        public List<Schip> ToonSchepen()
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);
            MySqlCommand cmdToonSchepen = new MySqlCommand("SELECT * FROM Schip ", cnnLXZAM_Haven);
            cnnLXZAM_Haven.Open();

            MySqlDataReader dtr = cmdToonSchepen.ExecuteReader();
            List<Schip> lijst = new List<Schip>();
            while (dtr.Read())
            {
                Schip s = new Schip(
                    Convert.ToInt32(dtr["idSchip"]),
                    Convert.ToString(dtr["naam"]),
                    Convert.ToString(dtr["Type"]),
                    Convert.ToDouble(dtr["Lengte"]),
                    Convert.ToDouble(dtr["Breedte"]),
                    Convert.ToInt32(dtr["Capaciteit"]));
                lijst.Add(s);
            }

            cnnLXZAM_Haven.Close();
            return lijst;

        }
        
        public List<Product> ToonProducten()
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);
            MySqlCommand cmdToonProducten = new MySqlCommand("SELECT * FROM product ", cnnLXZAM_Haven);
            cnnLXZAM_Haven.Open();

            MySqlDataReader dtr = cmdToonProducten.ExecuteReader();
            List<Product> lijst = new List<Product>();
            while (dtr.Read())
            {
                Product p = new Product(
                    Convert.ToInt32(dtr["idProduct"]),
                    Convert.ToString(dtr["naam"]),
                    Convert.ToDouble(dtr["TotaalGewichtKG"]),
                    Convert.ToString(dtr["TypeVerpakking"])
                    );
                    
                lijst.Add(p);
            }

            cnnLXZAM_Haven.Close();
            return lijst;

        }

        // invoeg query

        public void HavenToevoegen(Haven h)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVoegToe = new MySqlCommand("INSERT INTO haven(naam,land,stad,Aantaldokken) VALUES(@nm,@ld,@sd,@atd)", cnnLXZAM_Haven);
            cmdVoegToe.Parameters.AddWithValue("nm", h.Naam);
            cmdVoegToe.Parameters.AddWithValue("ld", h.Land);
            cmdVoegToe.Parameters.AddWithValue("sd", h.Stad);
            cmdVoegToe.Parameters.AddWithValue("atd", h.aantalDokken);

            cnnLXZAM_Haven.Open();

            cmdVoegToe.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();
        }

        public void ProductToevoeg(Product p)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVoegToe = new MySqlCommand("INSERT INTO product(Naam,TotaalgewichtKG, typeVerpakking) VALUES(@nm, @kg, @vk)", cnnLXZAM_Haven);
            cmdVoegToe.Parameters.AddWithValue("nm",p.Naam);
            cmdVoegToe.Parameters.AddWithValue("kg", p.TotaalGewichtKG);
            cmdVoegToe.Parameters.AddWithValue("vk", p.TypeVerpakking);


            cnnLXZAM_Haven.Open();

            cmdVoegToe.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();
        }

        public void SchipToevoegen(Schip s)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVoegToe = new MySqlCommand("INSERT INTO schip(naam,type,lengte,breedte,capaciteit) VALUES(@nm, @tp, @lg, @bd, @cp)", cnnLXZAM_Haven);
            cmdVoegToe.Parameters.AddWithValue("nm", s.Naam);
            cmdVoegToe.Parameters.AddWithValue("tp", s.Type);
            cmdVoegToe.Parameters.AddWithValue("lg", s.Lengte);
            cmdVoegToe.Parameters.AddWithValue("bd", s.Breedte);
            cmdVoegToe.Parameters.AddWithValue("cp", s.Capaciteit);

            cnnLXZAM_Haven.Open();

            cmdVoegToe.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();

        }
            //Delete query

            public void HavenVerwijderen(Haven h)
            {
                MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

                MySqlCommand cmdVerwijder = new MySqlCommand("DELETE FROM haven where idHaven = @id", cnnLXZAM_Haven);
                cmdVerwijder.Parameters.AddWithValue("id", h.idHaven);

                cnnLXZAM_Haven.Open();

                cmdVerwijder.ExecuteNonQuery();

                cnnLXZAM_Haven.Close();
            }

        public void SchipVerwijderen(Schip s)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVerwijder = new MySqlCommand("DELETE FROM schip where idschip = @id", cnnLXZAM_Haven);
            cmdVerwijder.Parameters.AddWithValue("id", s.idSchip);

            cnnLXZAM_Haven.Open();

            cmdVerwijder.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();
        }

        public void ProductVerwijderen(Product p)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVerwijder = new MySqlCommand("DELETE FROM Product where idproduct = @id", cnnLXZAM_Haven);
            cmdVerwijder.Parameters.AddWithValue("id", p.idProduct);

            cnnLXZAM_Haven.Open();

            cmdVerwijder.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();
        }
        public void HavenVeranderen(Haven h)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVerander = new MySqlCommand("Update haven Set naam= @nm,land=@ld,stad=@sd,Aantaldokken=@ad where idHaven = @id", cnnLXZAM_Haven);
            cmdVerander.Parameters.AddWithValue("id", h.idHaven);
            cmdVerander.Parameters.AddWithValue("nm", h.Naam);
            cmdVerander.Parameters.AddWithValue("ld", h.Land);
            cmdVerander.Parameters.AddWithValue("sd", h.Stad);
            cmdVerander.Parameters.AddWithValue("ad", h.aantalDokken);
            cnnLXZAM_Haven.Open();

            cmdVerander.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();
        }

        public void SchipVeranderen(Schip s)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVerander = new MySqlCommand("Update schip Set naam= @nm,type= @tp,lengte =@lg,breedte= @bd,capaciteit =@cp where idSchip = @id", cnnLXZAM_Haven);
            cmdVerander.Parameters.AddWithValue("id", s.idSchip);
            cmdVerander.Parameters.AddWithValue("nm", s.Naam);
            cmdVerander.Parameters.AddWithValue("tp", s.Type);
            cmdVerander.Parameters.AddWithValue("lg", s.Lengte);
            cmdVerander.Parameters.AddWithValue("bd", s.Breedte);
            cmdVerander.Parameters.AddWithValue("cp", s.Capaciteit);

            cnnLXZAM_Haven.Open();

            cmdVerander.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();
        }

        public void ProductVeranderen(Product p)
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);

            MySqlCommand cmdVerander = new MySqlCommand("Update Product Set naam= @nm,TotaalgewichtKG= @kg, typeVerpakking= @vk where idProduct = @id", cnnLXZAM_Haven);
            cmdVerander.Parameters.AddWithValue("id", p.idProduct);
            cmdVerander.Parameters.AddWithValue("nm", p.Naam);
            cmdVerander.Parameters.AddWithValue("kg", p.TotaalGewichtKG);
            cmdVerander.Parameters.AddWithValue("vk", p.TypeVerpakking);



            cnnLXZAM_Haven.Open();

            cmdVerander.ExecuteNonQuery();

            cnnLXZAM_Haven.Close();
        }

        //route & productperroute


        public List<Route> ToonRoutes()
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);
            MySqlCommand cmdToonRoutes = new MySqlCommand("SELECT * FROM Route ", cnnLXZAM_Haven);
            cnnLXZAM_Haven.Open();

            MySqlDataReader dtr = cmdToonRoutes.ExecuteReader();
            List<Route> lijst = new List<Route>();
            while (dtr.Read())
            {
                Route r = new Route(
                    Convert.ToInt32(dtr["idRoute"]),
                    Convert.ToInt32(dtr["idSchip"]),
                    Convert.ToInt32(dtr["idHaven"]),
                    Convert.ToDateTime(dtr["VertrekDatum"]),
                    Convert.ToDateTime(dtr["AankomstDatum"]),
                    Convert.ToDouble(dtr["AfstandKM"]));
                lijst.Add(r);
            }

            cnnLXZAM_Haven.Close();
            return lijst;

        }

        public List<ProductPerRoute> ToonProductenPerRoutes()
        {
            MySqlConnection cnnLXZAM_Haven = new MySqlConnection(_connectionstring);
            MySqlCommand cmdProductenPerRoutes = new MySqlCommand("SELECT * FROM productperroute ", cnnLXZAM_Haven);
            cnnLXZAM_Haven.Open();

            MySqlDataReader dtr = cmdProductenPerRoutes.ExecuteReader();
            List<ProductPerRoute> lijst = new List<ProductPerRoute>();
            while (dtr.Read())
            {
                ProductPerRoute ppr = new ProductPerRoute(
                    Convert.ToInt32(dtr["idRoute"]),
                    Convert.ToInt32(dtr["idProduct"]),
                    Convert.ToInt32(dtr["AantalProduct"]));
                lijst.Add(ppr);
            }

            cnnLXZAM_Haven.Close();
            return lijst;

        }
    }
}
