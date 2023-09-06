using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Accessories.Amulets
{
    public class StoneAmulet : ModItem
    {



        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed *= 1.1f;
            player.statLifeMax2 += 5;
            player.GetCritChance(DamageClass.Generic) += 1f;



        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<WoodenAmulet>());
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddIngredient(ItemID.Blinkroot, 2);
            recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }



    }
}


