using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Items;

namespace TutorialMod.NPCs
{
    [AutoloadHead]
    internal class BuckyTheBucc : ModNPC
    {
        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 24;
            NPC.height = 52;
            NPC.aiStyle = 7;
            NPC.defense = 45;
            NPC.lifeMax = 300;
            NPC.HitSound = SoundID.NPCHit7;
            NPC.DeathSound = SoundID.NPCDeath24;
            NPC.knockBackResist = .7f;
            Main.npcFrameCount[NPC.type] = 25;
            NPCID.Sets.ExtraFramesCount[NPC.type] = 0;
            NPCID.Sets.AttackFrameCount[NPC.type] = 1;
            NPCID.Sets.DangerDetectRange[NPC.type] = 300;
            NPCID.Sets.AttackType[NPC.type] = 1;
            NPCID.Sets.AttackTime[NPC.type] = 50;
            NPCID.Sets.HatOffsetY[NPC.type] = 8;
            AnimationType = 22;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs)
        {
            if(NPC.downedFishron)
            {
                return true;
            }
            return false;
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string>()
            {
                "Bucky"
            };
        }
        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = "Shop";
        }
        public const string ShopName = "Shop";
        public override void OnChatButtonClicked(bool firstButton, ref string shop)
        {

            if (firstButton)
            {
                shop = ShopName;
            }
        }

        public override void AddShops()
        {
            var npcShop = new NPCShop(Type, ShopName);
            
            npcShop.Add(new Item(ModContent.ItemType<TutorialSword>()) { shopCustomPrice = Item.buyPrice(gold: 90) });
            if (ItemID.JourneymanBait != 5)
            {
                npcShop.Add(new Item(ItemID.JourneymanBait) { shopCustomPrice = Item.buyPrice(gold: 5) });
            }
             
            npcShop.Add(new Item(ItemID.CratePotion) { shopCustomPrice = Item.buyPrice(gold: 10) });
            npcShop.Add(new Item(ItemID.SpelunkerPotion) { shopCustomPrice = Item.buyPrice(gold: 10) });
            npcShop.Register();
            
        }
        public override string GetChat()
        {
            NPC.FindFirstNPC(ModContent.NPCType<BuckyTheBucc>());
            switch (Main.rand.Next(3))
            {
                case 0:
                    return "I actually had meself a sidegig before I went back to the seas. Ever heard of a college mascot before?";

                case 1:
                    return "Thanks for taking care of Fishron for me, he's been terrorizing me crew for ages!";

                case 2:
                    return "I got some wares for ye, if you got coin.";
            }
            return "";
            
        }


    }
}
