using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Proj
{
    public class DarkStarProjB : ModProjectile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Magic;
            Projectile.width = 25;
            Projectile.height = 70;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 5;
            Projectile.timeLeft = 300;
            Projectile.light = 0.75f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
            Projectile.scale = 3f;
        }



        public override void Kill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }

        public override void AI()
        {
            int dust1 = Dust.NewDust(Projectile.position, Projectile.width + 5, Projectile.height + 5, 27);
            Main.dust[dust1].velocity = Projectile.velocity;
            Main.dust[dust1].scale = 2f;

            float velRotation = Projectile.velocity.ToRotation();

            Projectile.rotation = velRotation + MathHelper.ToRadians(0f);
        }




        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.ShadowFlame, 180);
            target.AddBuff(BuffID.Venom, 180);
        }


    }

}

