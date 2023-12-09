using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TutorialMod.Projectiles;

namespace TutorialMod.Items
{
    internal class Zombie_Eye_Weap : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.maxStack = 399;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 10;
            Item.height = 10;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = 5;
            Item.knockBack = 1;
            Item.value = 0;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Zombie_Eye>();
            Item.shootSpeed = 19;
            Item.crit = 5;
            Item.consumable = true;
        }
   
    }
}
