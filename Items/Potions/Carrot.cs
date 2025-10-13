using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;

namespace MitaNPC.Items.Potions
{
    public class Carrot : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 30;
            Item.useTurn = true;
            Item.maxStack = Item.CommonMaxStack;
            Item.useAnimation = 50;
            Item.useTime = 50;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.UseSound = new SoundStyle("MitaNPC/Sounds/CarrotConsume");
            Item.consumable = true;

            Item.value = Item.buyPrice(0, 0, 25, 0);
            Item.rare = ItemRarityID.Blue;

            Item.buffType = BuffID.WellFed2;
            Item.buffTime = 60 * 180; // 3m
        }
    }
}
