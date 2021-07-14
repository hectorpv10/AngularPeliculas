using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.DTOs
{
    public class RespuestaAutenticacion
    {
        public string Token { get; set; }
        public DateTime Expiracion { get; set; }
    }
}
