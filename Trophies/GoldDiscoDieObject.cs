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
    [LocDisplayName("Gold Disco Die")]
    [LocDescription("Every dance floor needs one of these")]
    [Tag("Trophy")]
    public partial class GoldDiscoDieItem : WorldObjectItem<GoldDiscoDieObject>
    {

    }

    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]
    [RequireComponent(typeof(PropertyAuthComponent))]
    public partial class GoldDiscoDieObject : WorldObject, IRepresentsItem
    {
        static GoldDiscoDieObject()
        {
            WorldObject.AddOccupancy<GoldDiscoDieObject>(new List<BlockOccupancy>(){
                new BlockOccupancy(new Vector3i(0, 0, 0)),
            });
        }
        public Type RepresentedItemType => typeof(GoldDiscoDieItem);
        public override LocString DisplayName => Localizer.DoStr("Gold Disco Die");
        public override TableTextureMode TableTexture => TableTextureMode.Metal;
    }
}