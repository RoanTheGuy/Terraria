using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class DarkStar : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 157;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 9;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Pixie;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.DarkStarProjA>();
            Item.shootSpeed = 22f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.mana = 30;


        }


        public override void AddRecipes()
        {


            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<ShadowflameCane>(), 1);
            recipe.AddIngredient(ModContent.ItemType<ShadowNebuliumBar>(), 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();


        }


        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {

                float numberProjectiles = 7; //+ Main.rand.Next(3)  3, 4, or 5 shots
                float rotation = MathHelper.ToRadians(150);

                position += Vector2.Normalize(velocity) * 45f;

                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 1.8f; // Watch out for dividing by 0 if there is only 1 projectile.
                    Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);

                }

                return true;
        }



       





        public static void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.ShadowFlame, 180);
            target.AddBuff(BuffID.Venom, 180);
        }



    }
}