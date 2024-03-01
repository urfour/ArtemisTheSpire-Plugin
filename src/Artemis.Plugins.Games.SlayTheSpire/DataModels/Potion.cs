using Artemis.Core.Modules;
using System;

namespace Artemis.Plugins.Games.SlayTheSpire.DataModels
{
    public class Potion
    {
        public bool RequiresTarget { get; set; }
        public bool CanUse { get; set; }
        public bool CanDiscard { get; set; }
        public string? Name { get; set; }
        public string? CardId { get; set; }
    }
}