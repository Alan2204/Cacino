using Microsoft.AspNetCore.Mvc.Filters;

namespace Cacino.Filtros
{
    public class FiltrodeExepcion : ExceptionFilterAttribute
    {
        private readonly ILogger<FiltrodeExepcion> log;

        public FiltrodeExepcion(ILogger<FiltrodeExepcion> log)
        {
            this.log = log;
        }

        public override void OnException(ExceptionContext context)
        {
            log.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}
