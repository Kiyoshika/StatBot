using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord.Commands;

public class HelloWorld : ModuleBase<SocketCommandContext>
{
    [Command("say")]
    public async Task say()
    {
        ReplyAsync("Hello from StatBot");
    }
}