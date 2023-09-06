using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Accessories.Items.Proj
{
    public class HellfireTridentProjB : ModProjectile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.


        public override void SetStaticDefaults()
        {

        }




        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 10;
            Projectile.height = 10;
            Projectile.aiStyle = ProjAIStyleID.Arrow;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 4;
            Projectile.timeLeft = 680;
            Projectile.light = 0f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.scale = 1.5f;


        }



        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }

        public override void AI()
        {
            int dust1 = Dust.NewDust(Projectile.position, Projectile.width + 30, Projectile.height + 30, 6);
            Main.dust[dust1].velocity = Projectile.velocity;
        }

        public override void Kill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);

        }
    }
}