using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Accessories.Items.Other
{
    public class GlobalAmmo : GlobalItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Acorn)
            {
                item.ammo = ItemID.Acorn;
                item.shoot = ModContent.ProjectileType<Proj.AcornProj>();

            }


            if (item.type == ItemID.Cobweb)
            {
                item.ammo = ItemID.Cobweb;
                item.shoot = ModContent.ProjectileType<Proj.WebProj>();

            }


        }


        
    }
}