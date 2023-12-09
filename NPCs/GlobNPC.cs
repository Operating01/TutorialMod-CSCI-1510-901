using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Terraria;
using Terraria.Achievements;
using Terraria.Chat;
using Terraria.Chat.Commands;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using TutorialMod.Items;

namespace TutorialMod.NPCs
{
    internal class GlobNPC : GlobalNPC
    {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {

            if (Main.rand.Next(4) == 0)
            {
                if (npc.type == NPCID.Zombie || npc.type == NPCID.ZombieEskimo || npc.type == NPCID.ZombieRaincoat || npc.type == NPCID.BaldZombie || npc.type == NPCID.FemaleZombie || npc.type == NPCID.ArmedZombie || npc.type == NPCID.ArmedZombieEskimo || npc.type == NPCID.SmallBaldZombie || npc.type == NPCID.SmallZombie || npc.type == NPCID.SmallSlimedZombie || npc.type == NPCID.SmallFemaleZombie || npc.type == NPCID.SmallRainZombie || npc.type == NPCID.SmallTwiggyZombie || npc.type == NPCID.ZombieDoctor || npc.type == NPCID.BigBaldZombie || npc.type == NPCID.BigFemaleZombie || npc.type == NPCID.BigRainZombie || npc.type == NPCID.BigSwampZombie || npc.type == NPCID.BigTwiggyZombie)
                {
                    if (NPC.downedBoss1 == false)
                    {
                        npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zombie_Eye_Weap>()));

                    }
                }
            }
            if (NPC.downedBoss1)
            {
                npcLoot.Remove(npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Zombie_Eye_Weap>())));

            }

            if (NPC.downedSlimeKing)
            {
                npcLoot.Add(npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KnockBow>())));
            }
            if (NPC.downedFishron)
            {
                npcLoot.Add(npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KnockBow>())));
            }
        }
    } 
}
        

