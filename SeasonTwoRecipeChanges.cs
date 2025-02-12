using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;

namespace Eco.Mods.TechTree
{
    /// Add Base paint as a static requirement                    
    public partial class AsphaltConcreteRecipe : RecipeFamily
    {
        partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(BasePaintItem), 1, true));
        }
    }
    
    // Add additional input to charred mortar
    public partial class CharredMortarRecipe : RecipeFamily
    {
        partial void ModsPreInitialize()
        {
            this.ReplaceIngredient("NaturalFiber", new IngredientElement("NaturalFiber", 10, true));
        }
    }

	// Reduce output to 1 and make sand input static
    public partial class MasonryMortarRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
        	this.ReplaceProduct(new CraftingElement<MortarItem>(1));
            this.ReplaceIngredient<SandItem>(new IngredientElement(typeof(SandItem), 1, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)));
        }
    }
    
    /// Replace with static inputs                 
    public partial class IronConcentrateRecipe : RecipeFamily
    {
        partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Clear();
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(CrushedIronOreItem), 4, true));
        }
    }
    
    public partial class ConcentrateDryIronRecipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Clear();
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(CrushedIronOreItem), 3, true));
        }
    }
    
    public partial class ConcentrateIronLv2Recipe : RecipeFamily
    {
    	partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Clear();
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(CrushedIronOreItem), 2, true));
            
            this.ReplaceProduct(new CraftingElement<IronConcentrateItem>(1));
        }
    }
    
    /// Replace with static inputs                 
    public partial class CopperConcentrateRecipe : RecipeFamily
    {
        partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Clear();
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(CrushedCopperOreItem), 6, true));
        }
    }
    
    /// Replace with static inputs                 
    public partial class ConcentrateCopperLv2Recipe : RecipeFamily
    {
        partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Clear();
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(CrushedCopperOreItem), 3, true));
            
            this.ReplaceProduct(new CraftingElement<CopperConcentrateItem>(1));
        }
    }
    
    /// Replace with static inputs                 
    public partial class GoldConcentrateRecipe : RecipeFamily
    {
        partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Clear();
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(CrushedGoldOreItem), 8, true));
        }
    }
    
    /// Replace with static inputs                 
    public partial class ConcentrateGoldLv2Recipe : RecipeFamily
    {
        partial void ModsPreInitialize()
        {
            this.Recipes[0].Ingredients.Clear();
            this.Recipes[0].Ingredients.Add(new IngredientElement(typeof(CrushedGoldOreItem), 4, true));
            
            this.ReplaceProduct(new CraftingElement<GoldConcentrateItem>(1));
        }
    }
}