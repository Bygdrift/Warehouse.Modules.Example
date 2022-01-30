using Bygdrift.Warehouse;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Module.Services;
using System.Threading.Tasks;

namespace Module.AppFunctions
{
    public class TimerTrigger
    {
        private readonly AppBase<Settings> app;

        public TimerTrigger(ILogger<TimerTrigger> logger) => app = new AppBase<Settings>(logger);

        [FunctionName(nameof(TimerTriggerAsync))]
        public async Task TimerTriggerAsync([TimerTrigger("0 0 1 * * *", RunOnStartup = true)] TimerInfo myTimer)
        {
            app.Log.LogInformation($"The module '{app.ModuleName}' is started");
            var data = WebService.GetData();
            await Refines.DataRefine.Refine(app, data);
        }
    }
}