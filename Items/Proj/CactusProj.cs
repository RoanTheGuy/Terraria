using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Accessories.Items.Proj
{
    public class CactusProj : ModProjectile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Magic;
            Projectile.width = 32;
            Projectile.height = 32;
            Projectile.aiStyle = ProjAIStyleID.ThrownProjectile;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 3;
            Projectile.timeLeft = 680;
            Projectile.light = 0f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.scale = 1.5f;
        }



        public override void Kill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);
        }

        public override void AI()
        {

            float velRotation = Projectile.velocity.ToRotation();

            Projectile.rotation = velRotation + MathHelper.ToRadians(0f);
        }






    }

}