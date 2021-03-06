using Terraria.ID;
using Terraria.ModLoader;

namespace InfernalSet.Items
{
	public class InfernalSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infernal Sword");
			Tooltip.SetDefault("Forged by the Fires of Hell.");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "InfernalBar", 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
