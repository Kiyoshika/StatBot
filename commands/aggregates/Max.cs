using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Max : ModuleBase<SocketCommandContext>
{

    [Command("max")]
    public async Task minimum(params Int64[] values)
    {
        Array.Sort(values);
        await Context.Channel.SendMessageAsync($"Maximum: {values[values.Length - 1]}");
    }

    [Command("max")]
    public async Task minimum(params double[] values)
    {
        Array.Sort(values);
        await Context.Channel.SendMessageAsync($"Maximum: {values[values.Length - 1]}");
    }
}