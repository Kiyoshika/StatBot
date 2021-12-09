using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class StDev : ModuleBase<SocketCommandContext>
{

    // for use with other modules or internally
    public static double _stdev(params Int64[] values)
    {
        // sample variance
        return Math.Sqrt(Variance._var(values));
    }

    // for use with other modules or internally
    public static double _stdev(params double[] values)
    {
        // sample variance
        return Math.Sqrt(Variance._var(values));
    }

    [Command("sd")]
    public async Task mean(params Int64[] values)
    {
        await Context.Channel.SendMessageAsync($"Sample StDev: {_stdev(values)}");
    }

    [Command("sd")]
    public async Task mean(params double[] values)
    {
        await Context.Channel.SendMessageAsync($"Sample StDev: {_stdev(values)}");
    }
}