// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Management.Automation;

namespace Microsoft.PowerShell.Commands
{
    /// <summary>
    /// This cmdlet says hello in Arabic.
    /// </summary>
    [Cmdlet(VerbsCommunications.Send, "ArabicGreeting", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2097141")]
    [OutputType(typeof(string))]
    public sealed class SendArabicGreetingCommand : PSCmdlet
    {
        /// <summary>
        /// Gets or sets the name to greet.
        /// </summary>
        [Parameter(Position = 0, ValueFromPipeline = true, ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; } = "العالم";

        /// <summary>
        /// ProcessRecord.
        /// </summary>
        protected override void ProcessRecord()
        {
            string greeting = $"مرحباً بك يا {Name} في باورشيل!";
            WriteObject(greeting);
        }
    }
}
