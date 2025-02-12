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
    [LocDisplayName("Bronze Trophy Cup")]
    [LocDescription("A small bronze trophy that will sit on a shelf in your spare bedroom and gather dust")]
    [Tag("Trophy")]
    public partial class BronzeTrophyCupItem : WorldObjectItem<BronzeTrophyCupObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    public partial class BronzeTrophyCupObject : WorldObject, IRepresentsItem
    {
        static BronzeTrophyCupObject()
        {
            WorldObject.AddOccupancy<BronzeTrophyCupObject>(new List<BlockOccupancy>(){
                new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
        }
        public Type RepresentedItemType => typeof(BronzeTrophyCupItem);
        public override LocString DisplayName => Localizer.DoStr("Bronze Trophy Cup");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;
    }
}