using PueblaContigo.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PueblaContigo.Interfaces
{
   public interface ApiInterface
    {
        #region Get Lista Usuarios
        [Get("/API/listausuarios.php?solicitud=ListaU&TRE5SF6GDTEFSR769=JSCNNER7YH35R9W4N3")]
        Task<List<User>> GetUserAsync();
        #endregion

        #region Get lista Vehiculos
        [Get("/API/listavehiculos2.php?TRE5SF6NE88T96DS=J345K4H5JK3H45J5JK3H&solicitud=ListaV&depend={depend}")]
        Task<List<Vehiculo>> GetVehiclesAsync(string depend);
        #endregion

        #region Get lista municipios
        [Get("/API/listaregionmun2.php?solicitud=ListaM&YSTEFSF6NE876YD54HS=53TGED7UH5TG0OIKJER")]
        Task<List<Municipio>> GetMunAsync();
        #endregion

        //#region Get lista apoyos
        //[Get("/API/listaapoyos2.php?solicitud=ListaA&YSTEFSF6N3E5DTG3EDYE=0O3IERFUJERF7YTGERFJHU&depend={depend}")]
        //Task<List<Apoyo>> GetApoyosAsync(string depend);
        //#endregion

        #region get apoyos por camioneta
        [Get("/API/listacarga2.php?solicitud=ListaAV&TRE5SF6NRFTGY=J345K4H5JK3H4ERFCUI23&depend={depend}&QRV={qrv}")]
        Task<List<Apoyo>> GetApoyosAsync(string depend,string qrv);
        #endregion 

        #region Post apoyos en camioneta
        [Post("/API/Insertarcarga2.php")]
        Task<Entrega> SendCargar(Entrega entrega);
        #endregion

        #region Post reportes
        #endregion

        #region Pos devolucion apoyos y/o vehiculo
        #endregion
        

    }
}
