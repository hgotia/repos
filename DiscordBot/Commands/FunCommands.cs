using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.Entities;
using System.Linq;

namespace DiscordBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("ping")]
        [Description("Returns pong")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel
                .SendMessageAsync("Pong")
                .ConfigureAwait(false);
        }

        [Command("plannedabsence")]
        [Description("Returns the email addresses we need to send the calendar invite to")]
        public async Task plannedabsence(CommandContext ctx)
        {
            await ctx.Channel
                .SendMessageAsync("Send a calendar invite to \n - ecc1@erau.edu and \n - SanDiegoMSSA@outlook.com \nalong with your planned absence form.")
                .ConfigureAwait(false);
        }

        [Command("goodmorning")]
        public async Task goodmorning(CommandContext ctx)
        {
            await ctx.Channel
                .SendMessageAsync($"Good Morning, {ctx.User.Username}!")
                .ConfigureAwait(false);
        }

        [Command("add")]
        [Description("Adds two integers together")]
        public async Task Add(CommandContext ctx, int numberOne, int numberTwo)
        {
            await ctx.Channel
                .SendMessageAsync((numberOne + numberTwo).ToString())
                .ConfigureAwait(false);
        }

        [Command("echo")]
        [Description("Echos everything for 2 minutes")]
        public async Task Echo(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            await ctx.Message.DeleteAsync().ConfigureAwait(false);

            var message = await interactivity
                .WaitForMessageAsync(x => x.Channel == ctx.Channel)
                .ConfigureAwait(false);

            await ctx.Channel
                .SendMessageAsync(message.Result.Content);
        }

        [Command("respondreaction")]
        public async Task RespondReaction(CommandContext ctx)
        {
            var interactivity = ctx.Client.GetInteractivity();

            var message = await interactivity.WaitForReactionAsync(x => x.Channel == ctx.Channel).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync(message.Result.Emoji);
        }

        [Command("emojipoll")]
        public async Task emojiPoll(CommandContext ctx, string pollTitle, TimeSpan duration, params DiscordEmoji[] emojiOptions)
        {
            var interactivity = ctx.Client.GetInteractivity();
            var options = emojiOptions.Select(x => x.ToString());

            var pollEmbed = new DiscordEmbedBuilder
            {
                Title = pollTitle,
                Description = string.Join(" ", options)
            };

            var pollMessage = await ctx.Channel.SendMessageAsync(embed: pollEmbed).ConfigureAwait(false);

            foreach (var option in emojiOptions)
            {
                await pollMessage.CreateReactionAsync(option).ConfigureAwait(false);
            }

            var result = await interactivity.CollectReactionsAsync(pollMessage, duration).ConfigureAwait(false);
            var distinctResult = result.Distinct();

            var results = distinctResult.Select(x => $"{x.Emoji} = {x.Total}");

            await ctx.Channel.SendMessageAsync("Poll Results:\n" + string.Join("\n", results)).ConfigureAwait(false);
        }
    }
}