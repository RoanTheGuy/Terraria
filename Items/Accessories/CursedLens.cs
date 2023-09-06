using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Accessories
{
    public class CursedLens : ModItem
    {



        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.buffImmune[BuffID.CursedInferno] = true;
            player.AddBuff(BuffID.WeaponImbueCursedFlames, 20);


        }





    }
}


