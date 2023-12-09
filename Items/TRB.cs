using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;

namespace TutorialMod.Items
{
    internal class TRB : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 15;
            Item.height = 15;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 52;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = .5f;
            Item.shoot = ProjectileID.Bullet;
            Item.UseSound = SoundID.Item1;
            Item.useAmmo = AmmoID.Bullet;
            Item.shootSpeed = 999f;
            Item.useAnimation = 18; 
            Item.useTime = 6; 
            Item.reuseDelay = 14; 
            Item.consumeAmmoOnLastShotOnly = true; 
            Item.autoReuse = true;
        }

    }
}
