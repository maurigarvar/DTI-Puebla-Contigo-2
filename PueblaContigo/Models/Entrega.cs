using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
namespace PueblaContigo.Models
{
    public class Entrega
    {
        [PrimaryKey]
        public string QRV { get; set; }
        [PrimaryKey]
        public string QRA { get; set; }
        public string REG { get; set; }
        public string MUN { get; set; }
        public DateTime fecha_carga { get; set; }
        public string USR { get; set; }
        public string user_responsable { get; set; }
        public DateTime fecha_responsable { get; set; }
        public string user_entrega { get; set; }
        public DateTime fecha_entrega { get; set; }
        public string curp { get; set; }
        public string nombre_completo { get; set; }
        public string incid_doc { get; set; }
        public string geolocalizacion { get; set; }
        public string identificacion { get; set; }
        public string comprobante_dom { get; set; }
        public string foto_bene { get; set; }
        public DateTime fecha_incidente { get; set; }
        public string incidente { get; set; }
        public string foto_incidente1 { get; set; }
        public string foto_incidente2 { get; set; }
        public string geolocalizacion_i { get; set; }
    }
}
   