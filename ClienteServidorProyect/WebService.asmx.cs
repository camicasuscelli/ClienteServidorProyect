using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ClienteServidorProyect
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        //este servicio web se encarga de recibir los strings de la aplicación o web y se conecta a la bd. Osea ejecuta 
        //los storage procedure de la bd :D

        [WebMethod]
        public string Login(string nombre, string password)
        {
            //este método web debería llamarse desde la pág web, recibir los parámetros que serían el usuario y contraseña y consultar en la bd
            //si existe el usuario ingresado.
            //return nombre +" " + password;
            //ahora debería conectarme a la bd.

        }
    }
}
