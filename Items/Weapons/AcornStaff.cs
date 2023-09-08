
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Weapons
{
    public class AcornStaff : ModItem
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 32;
            Item.useAnimation = 32;
            Item.useStyle = 9;
            Item.knockBack = 7;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Proj.AcornProj>();
            Item.shootSpeed = 5f;
            Item.scale *= 1.2f;
            Item.noMelee = true;
            Item.useAmmo = ItemID.Acorn;

        }

        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 15);
            recipe.AddIngredient(ItemID.Acorn, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}

