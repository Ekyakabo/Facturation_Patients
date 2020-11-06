
using System;
using System.Data;

namespace Facture.Connexion
{
    internal interface IConnection
    {
        ConnexionType TypeConnexion { get; set; }
        IDbConnection Initialise();
    }
}
