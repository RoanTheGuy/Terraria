using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items
{
    public class ShadowNebuliumBar : ModItem
    {



        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 9999;
            Item.rare = ItemRarityID.Red;

        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DemoniteBar, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 1);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 1);
            recipe.AddIngredient(ItemID.BeetleHusk, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddIngredient(ItemID.FragmentNebula, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }




    }
}



