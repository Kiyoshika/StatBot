using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Mean : ModuleBase<SocketCommandContext>
{

    // for use with other modules or internally
    public static double _mean(params Int64[] values)
    {
        Int64 sum = Sum._sum(values);
        return (double)sum / values.Length;
    }

    // for use with other modules or internally
    public static double _mean(params double[] values)
    {
        double sum = Sum._sum(values);
        return sum / values.Length;
    }

    [Command("mean")]
    public async Task mean(params Int64[] values)
    {
        await Context.Channel.SendMessageAsync($"Mean: {_mean(values)}");
    }

    [Command("mean")]
    public async Task mean(params double[] values)
    {
        await Context.Channel.SendMessageAsync($"Mean: {_mean(values)}");
    }
}