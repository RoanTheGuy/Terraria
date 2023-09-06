using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Accessories.Items.Accessories.Boots
{
    public class OceanBoots : ModItem
    {



        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.waterWalk = true;
            player.waterWalk2 = true;
            player.moveSpeed += 1f;
            player.accFlipper = true;



        }




        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SailfishBoots, 1);
            recipe.AddIngredient(ItemID.WaterWalkingBoots, 1);
            recipe.AddIngredient(ItemID.Flipper, 1);
            recipe.AddIngredient(ItemID.Coral, 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }




    }



}