using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Accessories.Items.Accessories.Amulets
{
    public class GlobalNPCs : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.GoblinSummoner)
            {
                npcLoot.Add(Terraria.GameContent.ItemDropRules.ItemDropRule.Common(ModContent.ItemType<Shadowflame>(), 1, 5, 10));
            }

            if (npc.type == NPCID.Probe)
            {
                npcLoot.Add(Terraria.GameContent.ItemDropRules.ItemDropRule.Common(ModContent.ItemType<BrokenProbe>(), 20, 1, 1));
            }


            if (npc.type == NPCID.PrimeLaser)
            {
                npcLoot.Add(Terraria.GameContent.ItemDropRules.ItemDropRule.Common(ModContent.ItemType<BrokenPrimeLaser>(), 2, 1, 1));
            }


            if (npc.type == NPCID.Retinazer)
            {
                npcLoot.Add(Terraria.GameContent.ItemDropRules.ItemDropRule.Common(ModContent.ItemType<LaserLens>(), 2, 1, 1));
            }


            if (npc.type == NPCID.Spazmatism)
            {
                npcLoot.Add(Terraria.GameContent.ItemDropRules.ItemDropRule.Common(ModContent.ItemType<CursedLens>(), 2, 1, 1));
            }
        }



    }

}