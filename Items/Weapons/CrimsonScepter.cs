using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class CrimsonScepter : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 29;
            Item.DamageType = DamageClass.Magic;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = 9;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Drip;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.CrimsonScepterProj>();
            Item.shootSpeed = 15f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.mana = 11;


        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CrimtaneBar, 15);
            recipe.AddIngredient(ItemID.TissueSample, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();




        }
    }
}

