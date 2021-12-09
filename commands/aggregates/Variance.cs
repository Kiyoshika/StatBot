using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Variance : ModuleBase<SocketCommandContext>
{

    // for use with other modules or internally
    public static double _var(params Int64[] values)
    {
        double mean = Mean._mean(values);
        double result = 0;
        foreach (Int64 val in values)
        {
            result += ((double)val - mean) * ((double)val - mean);
        }
        // sample variance
        return result / (values.Length - 1);
    }

    // for use with other modules or internally
    public static double _var(params double[] values)
    {
        double mean = Mean._mean(values);
        double result = 0;
        foreach (double val in values)
        {
            result += (val - mean)*(val - mean);
        }
        // sample variance
        return result / (values.Length - 1);
    }

    [Command("var")]
    public async Task mean(params Int64[] values)
    {
        await Context.Channel.SendMessageAsync($"Sample Variance: {_var(values)}");
    }

    [Command("var")]
    public async Task mean(params double[] values)
    {
        await Context.Channel.SendMessageAsync($"Sample Variance: {_var(values)}");
    }
}