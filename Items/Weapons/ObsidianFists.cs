using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class ObsidianFists : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.ergher

        public override void SetDefaults()
        {
            Item.damage = 32;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 9;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.ObsidianFistsProj>();
            Item.shootSpeed = 18f;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.mana = 9;
            

        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DemoniteBar, 15);
            recipe.AddIngredient(ItemID.ShadowScale, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();




        }
    }
}

