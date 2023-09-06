using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using Mono.Cecil;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.PlayerDrawLayer;

namespace Accessories.Items.Proj
{
    public class ObsidianFistsProj : ModProjectile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Magic;
            Projectile.width = 10;
            Projectile.height = 10;
            Projectile.friendly = true;
            Projectile.aiStyle = 1;
            Projectile.hostile = false;
            Projectile.penetrate = 5;
            Projectile.timeLeft = 300;
            Projectile.light = 0.75f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.scale = 1.5f;


            AIType = ProjectileID.ChlorophyteBullet;
        }



        public override void Kill(int timeLeft)
        {
            // This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
            Collision.HitTiles(Projectile.position + Projectile.velocity, Projectile.velocity, Projectile.width, Projectile.height);
            SoundEngine.PlaySound(SoundID.Item10, Projectile.position);





        int dust1 = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 27);
            Main.dust[dust1].velocity = Projectile.velocity;
            Main.dust[dust1].noGravity = true;
            Main.dust[dust1].scale = 2f;

            int dust2 = Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, 27);
            Main.dust[dust2].velocity = Projectile.velocity;
            Main.dust[dust2].noGravity = true;
            Main.dust[dust2].scale = 2f;

        }




        public override void AI()
        {
            float velRotation = Projectile.velocity.ToRotation();

            Projectile.rotation = velRotation + MathHelper.ToRadians(90f);


            Main.dust[DustID.ChlorophyteWeapon].velocity.Y = -222f;





        }



        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {

        }


    }

}