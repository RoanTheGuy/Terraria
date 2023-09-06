using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class WebStaff : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 34;
            Item.useAnimation = 34;
            Item.useStyle = 9;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.WebProj>();
            Item.shootSpeed = 10f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.useAmmo = ItemID.Cobweb;
        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SilverBar, 15);
            recipe.AddIngredient(ItemID.Cobweb, 20);
            recipe.AddIngredient(ItemID.Amethyst, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();


            Recipe recipe1 = CreateRecipe();
            recipe1.AddIngredient(ItemID.TungstenBar, 15);
            recipe1.AddIngredient(ItemID.Cobweb, 20);
            recipe1.AddIngredient(ItemID.Amethyst, 2);
            recipe1.AddTile(TileID.Anvils);
            recipe1.Register();




        }
    }
}

