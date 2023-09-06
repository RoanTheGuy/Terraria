using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using System;

namespace Accessories.Items.Weapons
{
    public class Flashbang : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.autoReuse = true;
            Item.shootSpeed = 5f;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<Proj.FlashbangProj>();
            Item.consumable = true;
            Item.maxStack = 9999;

        }





        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(10);
            recipe.AddIngredient(ItemID.Grenade, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.Register();




        }





        public static void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Confused, 240);
        }







    }
}