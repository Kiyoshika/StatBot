using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Prod : ModuleBase<SocketCommandContext>
{

    [Command("prod")]
    public async Task prod(params Int64[] values)
    {
        Int64 prod = 1;
        foreach (Int64 val in values)
        {
            prod *= val;
        }

        await Context.Channel.SendMessageAsync($"Product: {prod}");
    }

    [Command("prod")]
    public async Task prod(params double[] values)
    {
        double prod = 1.0;
        foreach (double val in values)
        {
            prod *= val;
        }

        await Context.Channel.SendMessageAsync($"Product: {prod}");
    }
}