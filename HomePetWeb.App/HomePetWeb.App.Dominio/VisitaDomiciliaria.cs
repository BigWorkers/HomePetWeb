using System;

namespace HomePetWeb.App.Dominio
{
    public class VisitaDomicilio
    {
        public int Id{get;set;}
        public string Temperatura {get;set;}
        public string Peso {get;set;}
        public string FrecuenciaRespiratoria {get;set;}
        public string FrecuenciaCardiaca {get;set;}
        public string EstadoAnimo {get;set;}
        public string FechaVisita {get;set;}
        public string IdVeterinario {get;set;}

    }
}
