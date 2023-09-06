using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Accessories.Amulets
{
    public class WoodenAmulet : ModItem
    {



        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed *= 1.05f;
            player.statLifeMax2 += 5;



        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 20);
            recipe.AddIngredient(ItemID.BorealWood, 20);
            recipe.AddIngredient(ItemID.RichMahogany, 20);
            recipe.AddIngredient(ItemID.Acorn, 10);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }



    }
}


