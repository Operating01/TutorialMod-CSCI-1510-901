using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.CodeAnalysis;
using System;
using System.Numerics;

namespace TutorialMod.Projectiles
{
	public class DarkSealerProjectile : ModProjectile
	{
        

		public override void SetStaticDefaults()
		{
			Main.projFrames[Projectile.type] = 3;
        }
		public override void SetDefaults()
		{
			Projectile.Name = "DarkSealerProjectile";
			Projectile.DamageType = DamageClass.Melee;
			Projectile.width = 6;
			Projectile.height = 6;
			Projectile.aiStyle = 0;
			Projectile.friendly = true;
			Projectile.hostile = false;
			Projectile.penetrate = 1;
			Projectile.timeLeft = 500;
			Projectile.light = 3f; 
			Projectile.ignoreWater = true;
			Projectile.tileCollide = false;
		}

        public override void AI()
        { 
			
            Projectile.rotation = (float)Math.Atan2((double)Projectile.velocity.Y, (double)Projectile.velocity.X) ;
            if (++Projectile.frameCounter >= 4)
            {
                Projectile.frameCounter = 0;
                
                if (++Projectile.frame >= Main.projFrames[Projectile.type])
                    Projectile.frame = 0;
            }
        } 
        
    }
}