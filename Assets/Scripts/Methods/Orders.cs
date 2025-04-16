using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Orders : MonoBehaviour
{
    // Resources
    Random random = new Random();
    List<Recipe> recipes = new List<Recipe>();

    // Sub-Main Methods
    public Recipe GetRandomRecipe()
    {
        int randomIndex = random.Next(0, recipes.Count - 1);
        Recipe randomRecipe = recipes[randomIndex];
        return randomRecipe;
    }
}
