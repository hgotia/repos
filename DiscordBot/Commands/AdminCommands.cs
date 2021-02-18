﻿using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Enums;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    [RequirePermissions(Permissions.Administrator)]
    public sealed class AdminCommands : BaseCommandModule
    {
        private DiscordEmoji[] _pollEmojiCache;

        /// <summary>
        /// A simple emoji based yes/no poll.
        /// </summary>
        /// <param name="commandContext">CommandContext of the message that has executed this command</param>
        /// <param name="duration">Amount of time how long the poll should last.</param>
        /// <param name="question">Polls question</param>
        /// <returns></returns>
        [Command("poll"), Description("Start a simple emoji poll for a simple yes/no question"), Cooldown(2, 30, CooldownBucketType.Guild)]
        public async Task PollAsync(CommandContext commandContext, [Description("How long should the poll last. (e.g. 1m = 1 minute)")] TimeSpan duration, [Description("Poll question"), RemainingText] string question)
        {
            if (!string.IsNullOrEmpty(question))
            {
                var client = commandContext.Client;
                var interactivity = client.GetInteractivity();
                if (_pollEmojiCache == null)
                {
                    _pollEmojiCache = new[] {
                        DiscordEmoji.FromName(client, ":white_check_mark:"),
                        DiscordEmoji.FromName(client, ":x:")
                    };
                }

                // This removes the poll command after the poll is created
                await commandContext.Message.DeleteAsync().ConfigureAwait(false);

                // Creating the poll message
                var pollStartText = new StringBuilder();
                pollStartText.Append("**").Append("Poll started for:").AppendLine("**");
                pollStartText.Append(question);
                var pollStartMessage = await commandContext.RespondAsync(pollStartText.ToString());

                // DoPollAsync adds automatically emojis out from an emoji array to a special message and waits for the "duration" of time to calculate results.
                var pollResult = await interactivity.DoPollAsync(pollStartMessage, _pollEmojiCache, PollBehaviour.DeleteEmojis, duration);
                var yesVotes = pollResult[0].Total;
                var noVotes = pollResult[1].Total;

                // Printing out the result
                var pollResultText = new StringBuilder();
                pollResultText.AppendLine(question);
                pollResultText.Append("Poll result: ");
                pollResultText.Append("**");
                if (yesVotes > noVotes)
                {
                    pollResultText.Append("Yes");
                }
                else if (yesVotes == noVotes)
                {
                    pollResultText.Append("Undecided");
                }
                else
                {
                    pollResultText.Append("No");
                }
                pollResultText.Append("**");
                await commandContext.RespondAsync(pollResultText.ToString());
            }
            else
            {
                await commandContext.RespondAsync("Error: the question can't be empty");
            }
        }

        [Command("sendtochannel"), Description("Send a message to a special channel")]
        public async Task SendToChannelAsync(CommandContext commandContext,
            [Description("Target discord channel")] DiscordChannel targetChannel,
            [Description("Message to send"), RemainingText] string message)
        {
            await targetChannel.SendMessageAsync(message);
        }
    }
}
