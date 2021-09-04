using System;
using System.Collections.Generic;
using System.Text;

namespace workshopAzure.Common.Responses
{
    public class Response
    {
        public bool IsSuccess { get; set; } //si es verdadero, devuelve el resultado, si es falso, saca el mensaje

        public string Message { get; set; }

        public object Result { get; set; }

    }
}
