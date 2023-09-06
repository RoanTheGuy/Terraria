using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class ShadowflameCane : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 55;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 40;
            Item.useAnimation = 40;
            Item.useStyle = 9;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Pixie;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.ShadowflameProj>();
            Item.shootSpeed = 15f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.mana = 30;


        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<ShadowRod>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Shadowflame>(), 10);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();




        }


        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {

            float numberProjectiles = 5; //+ Main.rand.Next(3)  3, 4, or 5 shots
            float rotation = MathHelper.ToRadians(90);

            position += Vector2.Normalize(velocity) * 45f;

            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1.2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);

            }
            return true;


        }


        public static void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.ShadowFlame, 180);
        }



    }
}

