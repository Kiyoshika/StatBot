using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Evaluate : ModuleBase<SocketCommandContext>
{
    [Command("evaluate")]
    public async Task evaluate(string expression)
    {
        double value = ExpressionEvaluator.evaluateExpression(ref expression);
        Context.Channel.SendMessageAsync($"Result: {value}");
    }
}