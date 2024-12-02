using Microsoft.AspNetCore.Mvc;
using Servicio.Conversiones;

namespace WebApi.Controllers
{
    /// <summary>
    /// Controlador que maneja las solicitudes relacionadas con las fechas.
    /// Autor: Rocio Chena
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FechaController : ControllerBase
    {
        private readonly FechaService _fechaService;

        // Constructor que inyecta el servicio FechaService
        public FechaController(FechaService fechaService)
        {
            _fechaService = fechaService;
        }

        /// <summary>
        /// Obtiene la fecha en formato corto "dd/MM/yyyy".
        /// </summary>
        /// <returns>La fecha en formato corto.</returns>
        [HttpGet("fecha-corta")]
        public IActionResult ObtenerFechaCorta()
        {
            var fechaCorta = _fechaService.ObtenerFechaFormatoCorto();
            return Ok(fechaCorta);
        }

        /// <summary>
        /// Obtiene la fecha en formato largo "dddd, dd MMMM yyyy".
        /// </summary>
        /// <returns>La fecha en formato largo.</returns>
        [HttpGet("fecha-larga")]
        public IActionResult ObtenerFechaLarga()
        {
            var fechaLarga = _fechaService.ObtenerFechaFormatoLargo();
            return Ok(fechaLarga);
        }

        /// <summary>
        /// Obtiene la fecha en formato ISO "yyyy-MM-ddTHH:mm:ss".
        /// </summary>
        /// <returns>La fecha en formato ISO.</returns>
        [HttpGet("fecha-iso")]
        public IActionResult ObtenerFechaISO()
        {
            var fechaISO = _fechaService.ObtenerFechaFormatoISO();
            return Ok(fechaISO);
        }
    }
}
