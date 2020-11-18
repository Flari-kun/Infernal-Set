using Terraria.ID;
using Terraria.ModLoader;

namespace InfernalSet.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class InfernalHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infernal Helmet");
			Tooltip.SetDefault("Not even Satan himself can get through that thick skull.");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.defense = 15;
		}

		

		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "InfernalBar", 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
