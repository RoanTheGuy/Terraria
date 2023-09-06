using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class HellfireTrident : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 34;
            Item.DamageType = DamageClass.Melee;
            Item.width = 80;
            Item.height = 80;
            Item.useTime = 11;
            Item.useAnimation = 11;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 3;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.autoReuse = true;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<Proj.HellfireTridentProjA>();

        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Trident, 1);
            recipe.AddIngredient(ItemID.DarkLance, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                Item.shoot = ModContent.ProjectileType<Proj.HellfireTridentProjB>();
                Item.damage = 34;
                Item.DamageType = DamageClass.Melee;
                Item.width = 40;
                Item.height = 40;
                Item.useTime = 11;
                Item.useAnimation = 11;
                Item.useStyle = ItemUseStyleID.Rapier;
                Item.knockBack = 6;
                Item.value = 10000;
                Item.rare = 2;
                Item.UseSound = SoundID.Item1;
                Item.shootSpeed = 10f;
                Item.noUseGraphic = true;
                Item.noMelee = true;


            }
            else { 
                Item.damage = 34;
                Item.DamageType = DamageClass.Melee;
                Item.width = 80;
                Item.height = 80;
                Item.useTime = 11;
                Item.useAnimation = 11;
                Item.useStyle = ItemUseStyleID.Rapier;
                Item.knockBack = 6;
                Item.value = 10000;
                Item.rare = 2;
                Item.UseSound = SoundID.Item1;
                Item.noUseGraphic = true;
                Item.noMelee = true;
                Item.shootSpeed = 2.1f;
                Item.shoot = ModContent.ProjectileType<Proj.HellfireTridentProjA>();
            }
            return base.CanUseItem(player);
        }


        public static void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }






    }
}

