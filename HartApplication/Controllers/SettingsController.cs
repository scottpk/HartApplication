using Microsoft.AspNetCore.Mvc;

namespace HartWebApi.Controllers
{
    /// <summary>
    /// Controller for managing settings
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
        private SettingsContext _ctx;
        public SettingsController(SettingsContext ctx)
        {
            _ctx = ctx;
        }
        /// <summary>
        /// Get list of all settings and their value
        /// </summary>
        /// <returns>all settings</returns>
        [HttpGet("GetSettings")]
        public IEnumerable<SettingsEntry> GetSettings()
        {
            return _ctx.Settings;
        }
        /// <summary>
        /// Get the currently configured timeout
        /// </summary>
        /// <returns>the timeout which is in seconds</returns>
        [HttpGet("GetTimeout")]
        public int GetTimeout()
        {
            return int.Parse(_ctx.Settings.Where(_ => _.Name == "Timeout").First().Value);
        }
        /// <summary>
        /// Get the message set to display after the timeout
        /// </summary>
        /// <returns>the message</returns>
        [HttpGet("GetTimeoutMessage")]
        public string GetTimeoutMessage()
        {
            return _ctx.Settings.Where(_ => _.Name == "TimeoutMessage").First().Value;
        }
    }
}
