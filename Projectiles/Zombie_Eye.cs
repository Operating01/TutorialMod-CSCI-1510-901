using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Projectiles
{
    internal class Zombie_Eye : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 6;
            Projectile.height = 6;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 500;
            Projectile.light = 10f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.light = .25f;
        }
        public override void AI()
        {
            Projectile.velocity.Y = Projectile.velocity.Y - .09f;
            Projectile.ai[0] += 1f;
            if (Projectile.velocity.Y >= 2f)
            {
                Projectile.velocity.Y = 2f;
            }
            if (Projectile.ai[0] == 2f)
            {
                Projectile.velocity.Y = Projectile.velocity.Y + .55f;
                Projectile.ai[0] = 0f;
            }


        }
    }
}
