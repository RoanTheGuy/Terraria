using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Accessories.Items.Weapons
{
    public class MoonBlade : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 31;
            Item.DamageType = DamageClass.Melee;
            Item.width = 20;
            Item.height = 20;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 3;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.scale = 1.25f;
            Item.shoot = ModContent.ProjectileType<Proj.MoonProj>();
            Item.shootSpeed = 12.5f;




        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.GoldBroadsword, 1);
            recipe.AddIngredient(ItemID.DemoniteBar, 5);
            recipe.AddIngredient(ItemID.Bone, 30);
            recipe.AddIngredient(ItemID.Cloud, 15);
            recipe.AddIngredient(ItemID.StoneBlock, 25);
            recipe.AddIngredient(ItemID.Moonglow, 5);
            recipe.AddTile(TileID.SkyMill);
            recipe.Register();

            Recipe recipe2 = CreateRecipe();
            recipe2.AddIngredient(ItemID.PlatinumBroadsword, 1);
            recipe2.AddIngredient(ItemID.DemoniteBar, 5);
            recipe2.AddIngredient(ItemID.Bone, 30);
            recipe2.AddIngredient(ItemID.Cloud, 15);
            recipe2.AddIngredient(ItemID.StoneBlock, 25);
            recipe2.AddIngredient(ItemID.Moonglow, 5);
            recipe2.AddTile(TileID.SkyMill);
            recipe2.Register();

            Recipe recipe3 = CreateRecipe();
            recipe3.AddIngredient(ItemID.GoldBroadsword, 1);
            recipe3.AddIngredient(ItemID.CrimtaneBar, 5);
            recipe3.AddIngredient(ItemID.Bone, 30);
            recipe3.AddIngredient(ItemID.Cloud, 15);
            recipe3.AddIngredient(ItemID.StoneBlock, 25);
            recipe3.AddIngredient(ItemID.Moonglow, 5);
            recipe3.AddTile(TileID.SkyMill);
            recipe3.Register();

            Recipe recipe4 = CreateRecipe();
            recipe4.AddIngredient(ItemID.PlatinumBroadsword, 1);
            recipe4.AddIngredient(ItemID.CrimtaneBar, 5);
            recipe4.AddIngredient(ItemID.Bone, 30);
            recipe4.AddIngredient(ItemID.Cloud, 15);
            recipe4.AddIngredient(ItemID.StoneBlock, 25);
            recipe4.AddIngredient(ItemID.Moonglow, 5);
            recipe4.AddTile(TileID.SkyMill);
            recipe4.Register();
        }

    }
}