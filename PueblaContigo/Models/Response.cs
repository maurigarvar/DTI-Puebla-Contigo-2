using System;
using System.Collections.Generic;
using System.Text;

namespace PueblaContigo.Models
{
    //modelo de respuesta
    public class Response
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }


    }
}
