using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Sum : ModuleBase<SocketCommandContext>
{

    // for use with other modules or internally
    public static Int64 _sum(params Int64[] values)
    {
        Int64 sum = 0;
        foreach (Int64 val in values) { sum += val; }
        return sum;
    }

    // for use with other modules or internally
    public static double _sum(params double[] values)
    {
        double sum = 0;
        foreach (double val in values) { sum += val; }
        return sum;
    }

    [Command("sum")]
    public async Task sum(params Int64[] values)
    {
        Int64 sum = _sum(values);
        await Context.Channel.SendMessageAsync($"Sum: {sum}");
    }

    [Command("sum")]
    public async Task sum(params double[] values)
    {
        double sum = _sum(values);
        await Context.Channel.SendMessageAsync($"Sum: {sum}");
    }
}