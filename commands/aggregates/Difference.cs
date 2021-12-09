using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Difference : ModuleBase<SocketCommandContext>
{

    [Command("diff")]
    public async Task difference(params Int64[] values)
    {
        bool firstValue = true;
        Int64 difference = -1; // temporary -1
        foreach (Int64 val in values)
        {
            if (firstValue) { difference = val; firstValue = false; continue; }
            difference -= val;
        }

        await Context.Channel.SendMessageAsync($"Difference: {difference}");
    }

    [Command("diff")]
    public async Task difference(params double[] values)
    {
        bool firstValue = true;
        double difference = -1.0; // temporary -1
        foreach (double val in values)
        {
            if (firstValue) { difference = val; firstValue = false; continue; }
            difference -= val;
        }

        await Context.Channel.SendMessageAsync($"Difference: {difference}");
    }
}