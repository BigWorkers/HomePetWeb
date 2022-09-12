using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePetWeb.App.Dominio;

namespace HomePetWeb.App.Persistencia.AppRepositorios
{
    public class RepositorioVisitaDomicilio : IRepositorioVisitaDomicilio
    {
        List<VisitaDomicilio> visitaDomicilios;

        public RepositorioVisitaDomicilio()
        {
            visitaDomicilios= new List<VisitaDomicilio>()
            {
                new VisitaDomicilio{Id=0,Temperatura="TEMPERATURA",Peso="PESO",FrecuenciaRespiratoria="FRECUENCIA RESPIRATORIA",FrecuenciaCardiaca="FRECUENCIA CARDIACA",EstadoAnimo="ESTADO ANIMO",FechaVisita="FECHA DE VISITA",IdVeterinario="ID VETERINARIO"},
                new VisitaDomicilio{Id=1,Temperatura="37,5" ,Peso="6 kg" ,FrecuenciaRespiratoria= "95",FrecuenciaCardiaca="65" ,EstadoAnimo="Alerta",FechaVisita="02/01/2022" ,IdVeterinario="3"},
                new VisitaDomicilio{Id=2,Temperatura="35,0",Peso="4 kg",FrecuenciaRespiratoria= "93" ,FrecuenciaCardiaca="76" ,EstadoAnimo="Calmado",FechaVisita="10/03/2022" ,IdVeterinario="1"},
                new VisitaDomicilio{Id=3,Temperatura="38,5" ,Peso="8 kg",FrecuenciaRespiratoria= "89",FrecuenciaCardiaca="55" ,EstadoAnimo="Letargico",FechaVisita="15/04/2022" ,IdVeterinario="2"},
                
            };
        }
        public VisitaDomicilio Add(VisitaDomicilio nuevoVisitaDomicilio)
        {
            nuevoVisitaDomicilio.Id=visitaDomicilios.Max(r=> r.Id) + 1;
            visitaDomicilios.Add(nuevoVisitaDomicilio);
            return nuevoVisitaDomicilio;
        }
        public IEnumerable<VisitaDomicilio> GetAll()
        {
            return visitaDomicilios;
        }
        public VisitaDomicilio GetVisitaDomicilioPorId(int visitaDomicilioId)
        {
            return visitaDomicilios.SingleOrDefault(s=> s.Id==visitaDomicilioId);
        }
        public IEnumerable<VisitaDomicilio> GetVisitaDomicilioPorFiltro(string filtro=null)
        {
            var visitaDomicilios =GetAll();
            if (visitaDomicilios != null)
            {
                if (!String.IsNullOrEmpty(filtro))

                {
                  visitaDomicilios=visitaDomicilios.Where(s=> s.Temperatura.Contains(filtro));  
                }
            }
            return visitaDomicilios;
        }

        public VisitaDomicilio Update(VisitaDomicilio VisitaDomicilioActualizado)
        {
            var visitaDomicilio = visitaDomicilios.SingleOrDefault(r=> r.Id==VisitaDomicilioActualizado.Id);
            if (visitaDomicilio !=null)
            {
                visitaDomicilio.Temperatura = VisitaDomicilioActualizado.Temperatura;
                visitaDomicilio.Peso =VisitaDomicilioActualizado.Peso;
                visitaDomicilio.FrecuenciaRespiratoria =VisitaDomicilioActualizado.FrecuenciaRespiratoria;
                visitaDomicilio.FrecuenciaCardiaca =VisitaDomicilioActualizado.FrecuenciaCardiaca;
                visitaDomicilio.EstadoAnimo = VisitaDomicilioActualizado.EstadoAnimo;
                visitaDomicilio.FechaVisita = VisitaDomicilioActualizado.FechaVisita;
                visitaDomicilio.IdVeterinario =VisitaDomicilioActualizado.IdVeterinario;
            
            }
            return visitaDomicilio;
        }

        
    }
}
