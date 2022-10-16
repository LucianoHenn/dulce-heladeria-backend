using Dulce.Heladeria.Services.Dtos;
using Dulce.Heladeria.Services.IManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Dulce.Heladeria.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemManager _itemManager;
        public ItemController(IItemManager itemManager)
        {
            _itemManager = itemManager;
        }

        [HttpPost]
        public async Task<IActionResult> InsertItem([FromBody] ItemDto item)
        {
            if(item == null)
            {
                return BadRequest(ModelState);
            }

            var result = await _itemManager.InsertItem(item);

            if (!result)
            {
                ModelState.AddModelError("error prueba", "Error al insertar nuevo intem");
                return StatusCode(StatusCodes.Status500InternalServerError, ModelState);
            }

            return NoContent();

        }
    }
}
