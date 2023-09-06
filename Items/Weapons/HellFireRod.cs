using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class HellFireRod : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 4;
            Item.useAnimation = 15;
            Item.useStyle = 9;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.HellFireProj>();
            Item.shootSpeed = 10f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.ArmorPenetration = 999;
            Item.mana = 3;

        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddIngredient(ItemID.AshWood, 20);
            recipe.AddIngredient(ItemID.Topaz, 1);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();


        }


        public static void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }





    }
}

