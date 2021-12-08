using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

public class Sum : ModuleBase<SocketCommandContext>
{
    [Command("sum")]
    public async Task sum(int a, int b)
    {
        await Context.Channel.SendMessageAsync($"The sum is: {a+b}");
    }
}