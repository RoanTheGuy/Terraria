using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Accessories.Boots
{
    public class JungleBoots : ModItem
    {



        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.hasJumpOption_Cloud = true;
            player.jumpBoost = true;
            player.jumpSpeedBoost = 0.5f;
            player.frogLegJumpBoost = true;
            player.noFallDmg = true;
            player.autoJump = true;
            player.rocketBoots = 1;
            player.moveSpeed += 1f;
            

            if (player.rocketFrame == true)  SoundEngine.PlaySound(SoundID.Item24);


        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SpectreBoots, 1);
            recipe.AddIngredient(ItemID.BlueHorseshoeBalloon, 1);
            recipe.AddIngredient(ItemID.FrogLeg, 1);
            recipe.AddIngredient(ItemID.PinkGel, 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.Register();
        }



    }
}

