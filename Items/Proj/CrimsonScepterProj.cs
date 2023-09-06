using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Proj
{
    public class CrimsonScepterProj : ModProjectile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Magic;
            Projectile.width = 10;
            Projectile.height = 10;
            Projectile.aiStyle = 12;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 4;
            Projectile.timeLeft = 680;
            Projectile.light = 0.75f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.scale = 2.3f;
        }



        public override void Kill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }

        public override void AI()
        {
            int dust1 = Dust.NewDust(Projectile.position, Projectile.width + 5, Projectile.height + 5, DustID.CrimtaneWeapons);
            Main.dust[dust1].velocity = Projectile.velocity;
            Main.dust[dust1].noGravity = true;
            Main.dust[dust1].scale = 1.5f;

            int dust2 = Dust.NewDust(Projectile.position, Projectile.width + 5, Projectile.height + 5, DustID.CrimtaneWeapons);
            Main.dust[dust2].velocity = Projectile.velocity;
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].scale = 1.5f;

        }



    }

}