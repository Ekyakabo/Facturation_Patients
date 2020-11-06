
using Facture.Connexion;
using ManagerConnection;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.Connexion
{   
        public class ImplementeConnexion : IConnection
        {
            private ImplementeConnexion()
            {

            }
        
            private IDbConnection _conn = null;
            private static ImplementeConnexion _instance = null;
            private ConnexionType _typeConnexion;
            public IDbConnection Conn
            {
                get
                {
                    return _conn;
                }

                set
                {
                    _conn = value;
                }
            }
            public static ImplementeConnexion Instance
            {
                get
                {
                    if (_instance == null)
                        _instance = new ImplementeConnexion();
                    return _instance;
                }
            }

        public ConnexionType TypeConnexion
        {
            get
            {
                return _typeConnexion;
            }

            set
            {
                _typeConnexion = value;
            }
        }
               

        public IDbConnection Initialise()
            {
            string chemin = "";
            
            switch (_typeConnexion)
                {
                    case ConnexionType.SQLServer:
                    chemin = File.ReadAllText(ClsConstante.Table.cheminSql);

                    if (!chemin.Equals(""))
                    {                       
                        _conn = new SqlConnection(chemin);
                    }

                    else
                        throw new InvalidOperationException("Le chemin de la base de données est vide!!!");
                    break;
                    case ConnexionType.MySQL:
                    //chemin = File.ReadAllText(ClsConstante.Table.cheminMysql);
                    if (!chemin.Equals(""))
                    {                       
                        _conn = new MySqlConnection(chemin);
                    }
                    else
                        throw new InvalidOperationException("Le chemin de la base de données est vide!!!");
                    break;
                  
                }
                return _conn;
            }

      
    }
}
