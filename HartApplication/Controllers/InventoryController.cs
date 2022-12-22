using HartWebApi;
using Microsoft.AspNetCore.Mvc;

namespace HartApplication.Controllers
{
    /// <summary>
    /// Controller for inventory related actions
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private InventoryContext _ctx;
        public InventoryController(InventoryContext ctx)
        {
            _ctx = ctx;
        }

        /// <summary>
        /// Get all possible items
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetItems")]
        public IEnumerable<InventoryItem> GetItems()
        {
            return _ctx.Items;
        }

        /// <summary>
        /// Get all inventory entries (as in, ungrouped)
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetInventoryEntries")]
        public IEnumerable<InventoryEntry> GetInventoryEntries()
        {
            return _ctx.Entries;
        }
        /// <summary>
        /// Get inventory. Each inventory response is a count grouped by item description
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetInventory")]
        public IEnumerable<InventoryResponse> GetInventory()
        {
            return _ctx.Entries.GroupBy(_ => _.Item.Description).Select(_ => new InventoryResponse
            {
                Description = _.Key,
                Count = _.Count()
            });
        }
    }
}