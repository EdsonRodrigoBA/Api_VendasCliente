using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCliente.Domain.Validation.Base
{
    public class Response
    {
        public List<Report> _report { get; }
        public static Response<T> OK<T>(T data) => new Response<T>(data);
        public static Response OK() => new Response();
        public static Response NaoProcessado(List<Report> report) => new Response(report);
        public static Response NaoProcessado(Report report) => new Response(report);


        public Response()
        {
            _report = new List<Report>();
        }
        public Response(List<Report> report)
        {
            _report = report;
        }

        public Response(Report report) : this(new List<Report>() { report })
        {

        }
    }


    public class Response<T> : Response
    {

        public T _data { get; set; }
        public Response()
        {
        }

        public Response(T data, List<Report> report = null):base(report)
        {
            _data = data;
        }
    }
}
