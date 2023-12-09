using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Items
{
    internal class KnockBow : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 1;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 25;
            Item.height = 25;
            Item.useTime = 11;
            Item.useAnimation = 22;
            Item.useStyle = 5;
            Item.knockBack = 15;
            Item.value = 10000;
            Item.rare = 2;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = 1;
            Item.useAmmo = AmmoID.Arrow;
            Item.shootSpeed = 16;
            Item.crit = 10;
            Item.consumeAmmoOnLastShotOnly = true;
            
        }
        
        



    }
}
