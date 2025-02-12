using Eco.Core.Items;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

namespace Trophies
{
    [Serialized]
    [Weight(1000)]
    [LocDisplayName("Silver House Trophy")]
    [LocDescription("A shiny silver trophy, worthy of second place")]
    [Tag("Trophy")]
    public partial class SilverHouseTrophyItem : WorldObjectItem<SilverHouseTrophyObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    public partial class SilverHouseTrophyObject : WorldObject, IRepresentsItem
    {
        static SilverHouseTrophyObject()
        {
            WorldObject.AddOccupancy<SilverHouseTrophyObject>(new List<BlockOccupancy>(){
                new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
        }
        public Type RepresentedItemType => typeof(SilverHouseTrophyItem);
        public override LocString DisplayName => Localizer.DoStr("Silver House Trophy");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;
    }
}