using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
namespace PueblaContigo.Models
{
    public class Vehiculo
    {
        [PrimaryKey]
        public string dependencia { get; set; }
        [PrimaryKey]
        public string id_qr_v { get; set; }
        public string placas { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public int estatus { get; set; }
    }
}