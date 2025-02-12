using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;

namespace Eco.Mods
{
	public static partial class RecipeExtensions
    {
        public static void ReplaceIngredient<T>(this RecipeFamily recipeFamily, IngredientElement element) where T : Item, new()
        {
            var recipe = recipeFamily.Recipes[0];
            var ingredients = recipe.Ingredients;
            var foundIndex = ingredients.FindIndex(x => x.Item.Type == typeof(T));

            ingredients[foundIndex] = element;
        }

        public static void ReplaceIngredient(this RecipeFamily recipeFamily, string tag, IngredientElement element)
        {
            var recipe = recipeFamily.Recipes[0];
            var ingredients = recipe.Ingredients;
            var foundIndex = ingredients.FindIndex(x => x.Tag?.Name == tag);

            ingredients[foundIndex] = element;
        }

        public static void ReplaceProduct<T>(this RecipeFamily recipeFamily, CraftingElement<T> element) where T : Item, new()
        {
            var recipe = recipeFamily.Recipes[0];
            var products = recipe.Products;
            var foundIndex = products.FindIndex(x => x.Item.Type == typeof(T));

            products[foundIndex] = element;
        }

        public static void ReplaceProduct<T, T2>(this RecipeFamily recipeFamily, CraftingElement<T2> element) where T2 : Item, new()
        {
            var recipe = recipeFamily.Recipes[0];
            var products = recipe.Products;
            var foundIndex = products.FindIndex(x => x.Item.Type == typeof(T));

            products[foundIndex] = element;
        }
    }
}