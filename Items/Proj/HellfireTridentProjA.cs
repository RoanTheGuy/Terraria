using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Accessories.Items.Proj
{
    public class HellfireTridentProjA : ModProjectile
    {
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.Accessories.hjson file.

        public override void SetDefaults()
        {
            Projectile.DamageType = DamageClass.Melee;
            Projectile.width = 40;
            Projectile.height = 40;
            Projectile.aiStyle = ProjAIStyleID.ShortSword;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = -1;
            Projectile.timeLeft = 300;
            Projectile.light = 0f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
            Projectile.scale = 2f;
            Projectile.extraUpdates = 1;
            Projectile.ownerHitCheck = true;


        }

        public override void AI()
        {
            base.AI();

            Projectile.rotation = Projectile.velocity.ToRotation() + MathHelper.PiOver2 - MathHelper.PiOver4 * Projectile.spriteDirection;

            int halfProjWidth = Projectile.width / 2;
            int halfProjHeight = Projectile.height / 2;

            DrawOriginOffsetX = 0;
            DrawOffsetX = -((32 / 2) - halfProjWidth);
            DrawOriginOffsetY = -((32 / 2) - halfProjHeight);

            int dust1 = Dust.NewDust(Projectile.position, Projectile.width + 5, Projectile.height + 5, 6);
            Main.dust[dust1].velocity = Projectile.velocity;



        }



        public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
        {
            target.AddBuff(BuffID.OnFire, 300);
        }



    }

}