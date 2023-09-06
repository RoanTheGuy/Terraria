using Microsoft.Xna.Framework;
using Mono.Cecil;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.PlayerDrawLayer;

namespace Accessories.Items.Weapons
{
    public class BookOfNeedles : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 18;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 45;
            Item.useAnimation = 45;
            Item.useStyle = 5;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.CactusProj>();
            Item.shootSpeed = 5f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.mana = 12;


        }


        public override void AddRecipes()
        {


            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.Cactus, 15);
            recipe.AddIngredient(ItemID.AntlionMandible, 8);
            recipe.AddIngredient(ItemID.SandBlock, 25);
            recipe.AddTile(TileID.Bookcases);
            recipe.Register();


        }


        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            

            float numberProjectiles = 5; //+ Main.rand.Next(3)  3, 4, or 5 shots
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

        }



    }
}