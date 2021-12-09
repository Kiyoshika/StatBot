using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Min : ModuleBase<SocketCommandContext>
{

    [Command("min")]
    public async Task minimum(params Int64[] values)
    {
        Array.Sort(values);
        await Context.Channel.SendMessageAsync($"Minimum: {values[0]}");
    }

    [Command("min")]
    public async Task minimum(params double[] values)
    {
        Array.Sort(values);
        await Context.Channel.SendMessageAsync($"Minimum: {values[0]}");
    }
}