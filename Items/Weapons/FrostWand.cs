using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using System;

namespace Accessories.Items.Weapons
{
    public class FrostWand : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.gesgrgdfsgf

        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.useStyle = 9;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.autoReuse = true;
            Item.shootSpeed = 8f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.mana = 11;
            Item.shoot = ModContent.ProjectileType<Proj.FrostStaffProjB>();

        }





        

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WandofFrosting, 1);
            recipe.AddIngredient(ItemID.FrostCore, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.Pearlwood, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();




        }



        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<Proj.FrostStaffProjA>(), damage, knockback, player.whoAmI);
            Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<Proj.FrostStaffProjC>(), damage, knockback, player.whoAmI);

            float numberProjectiles = 5; //+ Main.rand.Next(3)  3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(30);

            position += Vector2.Normalize(velocity) * 45f;

            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .7f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);

            }     return true;


        }



        public static void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Frostburn2, 180);
        }







    }
}