namespace HartWebApi
{
    /// <summary>
    /// Response object for GetInventory()
    /// </summary>
    public class InventoryResponse
    {
        /// <summary>
        /// The item's description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// How many units of this item in inventory
        /// </summary>
        public int Count { get; set; }
    }
}