using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Accessories.Items.Proj
{
    public class WaverangProj : ModProjectile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.


        public override void SetStaticDefaults()
        {

        }




        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 20;
            Projectile.height = 20;
            Projectile.aiStyle = ProjAIStyleID.Boomerang;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 300;
            Projectile.light = 0f;
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
            int dust1 = Dust.NewDust(Projectile.position, Projectile.width + 5, Projectile.height + 5, DustID.Water);
            Main.dust[dust1].velocity = Projectile.velocity;
            Main.dust[dust1].noGravity = true;
            Main.dust[dust1].scale = 1.5f;
        }

    }
}