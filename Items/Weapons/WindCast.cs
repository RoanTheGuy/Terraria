using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class WindCast : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 19;
            Item.DamageType = DamageClass.Melee;
            Item.width = 20;
            Item.height = 20;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 1;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 3;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.shootSpeed = 10f;
            Item.shoot = ModContent.ProjectileType<Proj.WindCastProj>();

        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WoodenBoomerang, 1);
            recipe.AddIngredient(ItemID.Feather, 8);
            recipe.AddIngredient(ItemID.Cloud, 15);
            recipe.AddTile(TileID.SkyMill);
            recipe.Register();
        }


        public override bool CanUseItem(Player player)       //this make that you can shoot only 1 boomerang at once
        {
            for (int i = 2; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == Item.shoot)
                {
                    return false;
                }
            }
            return true;
        }


    }
}