using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
namespace PueblaContigo.Models
{
    public class Apoyo
    {
        [PrimaryKey]
        public string dependencia { get; set; }
        [PrimaryKey]
        public string id_qr_a { get; set; }
        public string descripcion_apoyo { get; set; }
        public int estatus { get; set; }
    }
}