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
using System.ComponentModel;

namespace Trophies
{
    [Serialized]
    [Weight(1000)]
    [LocDisplayName("Golden Stars Award")]
    [LocDescription("A superb golden award")]
    [Tag("Trophy")]
    [Category("Hidden")]
    public partial class GoldenStarsAwardItem : WorldObjectItem<GoldenStarsAwardObject>
    {
        protected override OccupancyContext GetOccupancyContext => new SideAttachedContext(0 | DirectionAxisFlags.Down, WorldObject.GetOccupancyInfo(this.WorldObjectType));
    }

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(OccupancyRequirementComponent))]
    public partial class GoldenStarsAwardObject : WorldObject, IRepresentsItem
    {
        static GoldenStarsAwardObject()
        {
            WorldObject.AddOccupancy<GoldenStarsAwardObject>(new List<BlockOccupancy>(){
                new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
        }
        public Type RepresentedItemType => typeof(GoldenStarsAwardItem);
        public override LocString DisplayName => Localizer.DoStr("Golden Stars Award");
        public override TableTextureMode TableTexture => TableTextureMode.Wood;
    }
}