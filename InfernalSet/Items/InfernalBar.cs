using Terraria.ID;
using Terraria.ModLoader;

namespace InfernalSet.Items
{
    public class InfernalBar : ModItem
    {
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 14;
			item.maxStack = 99;
			item.value = 500;
			item.rare = ItemRarityID.Red;
			item.alpha = 0;
		}
          public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar);
            recipe.AddIngredient(ItemID.HallowedBar);
			recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}