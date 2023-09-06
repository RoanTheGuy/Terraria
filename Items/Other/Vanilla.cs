using Accessories.Items.Accessories.Amulets;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Other
{
    public class GlobalItems : ModSystem
    {
        public override void AddRecipes()
        {
            Recipe recipe1 = Recipe.Create(ItemID.TinkerersWorkshop);
            recipe1.AddIngredient(ItemID.Wood, 30);
            recipe1.AddIngredient(ItemID.Book, 5);
            recipe1.AddIngredient(ItemID.Silk, 10);
            recipe1.AddTile(TileID.Anvils);
            recipe1.Register();


            Recipe recipe2 = Recipe.Create(ItemID.PinkGel, 5);
            recipe2.AddIngredient(ItemID.Gel, 5);
            recipe2.AddIngredient(ItemID.PinkDye, 1);
            recipe2.AddTile(TileID.Solidifier);
            recipe2.Register();


            Recipe recipe3 = Recipe.Create(ItemID.Acorn, 1);
            recipe3.AddIngredient(ItemID.Wood, 1);
            recipe3.Register();



            Recipe recipe4 = Recipe.Create(ItemID.SandBoots, 1);
            recipe4.AddIngredient(ItemID.HermesBoots, 1);
            recipe4.AddCondition(Condition.InDesert);
            recipe4.Register();

            Recipe recipe5 = Recipe.Create(ItemID.FlurryBoots, 1);
            recipe5.AddIngredient(ItemID.HermesBoots, 1);
            recipe5.AddCondition(Condition.InSnow);
            recipe5.Register();

            Recipe recipe6 = Recipe.Create(ItemID.SailfishBoots, 1);
            recipe6.AddIngredient(ItemID.HermesBoots, 1);
            recipe6.AddCondition(Condition.InBeach);
            recipe6.Register();



            Recipe recipe7 = Recipe.Create(ItemID.BandofRegeneration, 1);
            recipe7.AddIngredient(ModContent.ItemType<Accessories.Band>());
            recipe7.AddIngredient(ItemID.LifeCrystal, 1);
            recipe7.AddTile(TileID.TinkerersWorkbench);
            recipe7.Register();



            Recipe recipe8 = Recipe.Create(ItemID.BandofStarpower, 1);
            recipe8.AddIngredient(ModContent.ItemType<Accessories.Band>());
            recipe8.AddIngredient(ItemID.ManaCrystal, 1);
            recipe8.AddTile(TileID.TinkerersWorkbench);
            recipe8.Register();



            Recipe recipe9 = Recipe.Create(ItemID.CloudinaBottle, 1);
            recipe9.AddIngredient(ItemID.Bottle, 1);
            recipe9.AddIngredient(ItemID.Cloud, 20);
            recipe9.AddIngredient(ItemID.Feather, 5);
            recipe9.AddTile(TileID.TinkerersWorkbench);
            recipe9.Register();


            Recipe recipe10 = Recipe.Create(ItemID.ShinyRedBalloon, 1);
            recipe10.AddIngredient(ItemID.WhiteString, 1);
            recipe10.AddIngredient(ItemID.Cloud, 10);
            recipe10.AddIngredient(ItemID.Feather, 5);
            recipe10.AddIngredient(ItemID.RedDye, 1);
            recipe10.AddTile(TileID.TinkerersWorkbench);
            recipe10.Register();


            Recipe recipe11 = Recipe.Create(ItemID.LuckyHorseshoe, 1);
            recipe11.AddIngredient(ItemID.GoldBar, 8);
            recipe11.AddTile(TileID.TinkerersWorkbench);
            recipe11.Register();


            Recipe recipe12 = Recipe.Create(ItemID.LuckyHorseshoe, 1);
            recipe12.AddIngredient(ItemID.PlatinumBar, 8);
            recipe12.AddTile(TileID.TinkerersWorkbench);
            recipe12.Register();


            Recipe recipe13 = Recipe.Create(ItemID.HermesBoots, 1);
            recipe13.AddIngredient(ItemID.Silk, 20);
            recipe13.AddIngredient(ItemID.GoldBar, 8);
            recipe13.AddIngredient(ItemID.WhiteString, 1);
            recipe13.AddIngredient(ItemID.Sunflower, 2);
            recipe13.AddTile(TileID.TinkerersWorkbench);
            recipe13.Register();


            Recipe recipe14 = Recipe.Create(ItemID.HermesBoots, 1);
            recipe14.AddIngredient(ItemID.Silk, 20);
            recipe14.AddIngredient(ItemID.PlatinumBar, 8);
            recipe14.AddIngredient(ItemID.WhiteString, 1);
            recipe14.AddIngredient(ItemID.Sunflower, 2);
            recipe14.AddTile(TileID.TinkerersWorkbench);
            recipe14.Register();


            Recipe recipe15 = Recipe.Create(ItemID.MagmaStone, 1);
            recipe15.AddIngredient(ItemID.Hellstone, 20);
            recipe15.AddIngredient(ItemID.Obsidian, 8);
            recipe15.AddTile(TileID.Hellforge);
            recipe15.Register();


            Recipe recipe16 = Recipe.Create(ItemID.ObsidianRose, 1);
            recipe16.AddIngredient(ItemID.Obsidian, 20);
            recipe16.AddIngredient(ItemID.Fireblossom, 5);
            recipe16.AddTile(TileID.Hellforge);
            recipe16.Register();


            Recipe recipe17 = Recipe.Create(ItemID.LavaCharm, 1);
            recipe17.AddIngredient(ItemID.Hellstone, 40);
            recipe17.AddIngredient(ItemID.LavaBucket, 5);
            recipe17.AddTile(TileID.Hellforge);
            recipe17.Register();


            Recipe recipe18 = Recipe.Create(ItemID.ShadowFlameHexDoll, 1);
            recipe18.AddIngredient(ItemID.GuideVoodooDoll, 1);
            recipe18.AddIngredient(ModContent.ItemType<Shadowflame>(), 10);
            recipe18.AddTile(TileID.MythrilAnvil);
            recipe18.Register();


            Recipe recipe19 = Recipe.Create(ItemID.ShadowFlameBow, 1);
            recipe19.AddIngredient(ItemID.HellwingBow, 1);
            recipe19.AddIngredient(ModContent.ItemType<Shadowflame>(), 10);
            recipe19.AddTile(TileID.MythrilAnvil);
            recipe19.Register();


            Recipe recipe20 = Recipe.Create(ItemID.ShadowFlameKnife, 1);
            recipe20.AddIngredient(ItemID.ThrowingKnife, 50);
            recipe20.AddIngredient(ModContent.ItemType<Shadowflame>(), 10);
            recipe20.AddTile(TileID.MythrilAnvil);
            recipe20.Register();


            Recipe recipe21 = Recipe.Create(ItemID.ThrowingKnife, 50);
            recipe21.AddIngredient(ItemID.IronBar, 1);
            recipe21.AddIngredient(ItemID.Wood, 1);
            recipe21.AddTile(TileID.Anvils);
            recipe21.Register();

            Recipe recipe22 = Recipe.Create(ItemID.Shuriken, 50);
            recipe22.AddIngredient(ItemID.IronBar, 1);
            recipe22.AddTile(TileID.Anvils);
            recipe22.Register();

            Recipe recipe23 = Recipe.Create(ItemID.Shackle, 1);
            recipe23.AddIngredient(ItemID.IronBar, 2);
            recipe23.AddTile(TileID.Anvils);
            recipe23.Register();

            Recipe recipe24 = Recipe.Create(ItemID.WoodenBoomerang, 1);
            recipe24.AddIngredient(ItemID.Wood, 10);
            recipe24.AddIngredient(ItemID.BorealWood, 10);
            recipe24.AddIngredient(ItemID.RichMahogany, 10);
            recipe24.AddIngredient(ItemID.Acorn, 5);
            recipe24.AddTile(TileID.WorkBenches);
            recipe24.Register();
        }
    } 
}
