﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delterra.Systems;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace Delterra.Content.Items.Accessories {
    public class BlueRibbon : ModItem {

        public override void SetDefaults() {
            Item.DefaultToAccessory();
            Item.rare = ItemRarityID.LightRed;
            Item.value = Terraria.Item.sellPrice(0, 1, 0, 0);
            Item.defense = 3;
        }

        public override void UpdateAccessory(Player player, bool hideVisual) {
            EquipmentEffectPlayer.Get(player).healingMultiplier += 0.2f;
        }

    }
}
