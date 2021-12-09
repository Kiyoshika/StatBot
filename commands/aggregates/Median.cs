using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Median : ModuleBase<SocketCommandContext>
{
    public static double _median(params Int64[] values)
    {
        Array.Sort(values);
        int size = values.Length;
        int midIndex = size / 2;
            
        if (size % 2 != 0)
            return values[midIndex];

        dynamic midVal1 = values[midIndex];
        dynamic midVal2 = values[midIndex - 1];
        return (values[midIndex] + midVal2) * 0.5;
    }
    public static double _median(params double[] values)
    {
        Array.Sort(values);
        int size = values.Length;
        int midIndex = size / 2;

        if (size % 2 != 0)
            return values[midIndex];

        dynamic midVal1 = values[midIndex];
        dynamic midVal2 = values[midIndex - 1];
        return (values[midIndex] + midVal2) * 0.5;
    }

    [Command("median")]
    public async Task median(params Int64[] values)
    {
        await Context.Channel.SendMessageAsync($"Median: {_median(values)}");
    }

    [Command("median")]
    public async Task median(params double[] values)
    {
        await Context.Channel.SendMessageAsync($"Median: {_median(values)}");
    }
}
