using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Accessories
{
    public class Band : ModItem
    {



        public override void SetDefaults()
        {
            Item.width = 10;
            Item.height = 10;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 1;



        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Chain, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }



    }
}


