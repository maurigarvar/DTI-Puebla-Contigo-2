using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PueblaContigo.Models
{
    //modelo usuario
    public class User
    {
        [PrimaryKey]
        public string id { get; set; }
        public string dependencia { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string tipo_usuario { get; set; }
        public string movil { get; set; }
    }
}
