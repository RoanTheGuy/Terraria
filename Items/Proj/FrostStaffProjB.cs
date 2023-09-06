using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Proj
{
    public class FrostStaffProjB : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Magic;
            Projectile.width = 10;
            Projectile.height = 10;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 2;
            Projectile.timeLeft = 680;
            Projectile.light = 0.75f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.scale = 1f;
        }



        public override void Kill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }

        public override void AI()
        {
            int dust1 = Dust.NewDust(Projectile.position, Projectile.width + 5, Projectile.height + 5, 92);
            Main.dust[dust1].velocity = Projectile.velocity;
            Main.dust[dust1].noGravity = true;


        }

        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.Frostburn2, 180);
        }

    }

}