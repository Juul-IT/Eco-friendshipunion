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
    [LocDisplayName("Gold Trophy Cup")]
    [LocDescription("An epic gold trophy to show off to everyone how truly amazing you are. You rock!")]
    [Tag("Trophy")]
    public partial class GoldTrophyCupItem : WorldObjectItem<GoldTrophyCupObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    public partial class GoldTrophyCupObject : WorldObject, IRepresentsItem
    {
        static GoldTrophyCupObject()
        {
            WorldObject.AddOccupancy<GoldTrophyCupObject>(new List<BlockOccupancy>(){
                new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
        }
        public Type RepresentedItemType => typeof(GoldTrophyCupItem);
        public override LocString DisplayName => Localizer.DoStr("Gold Trophy Cup");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;
    }
}