using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Orders : MonoBehaviour
{
    // Resources
    Random random = new Random();
    List<Recipe> recipes = new List<Recipe>();
    MatchStats matchStats = GameObject.FindGameObjectWithTag("Resources").GetComponent<MatchStats>();


    // Sub-Main Methods
    public Recipe GetRandomRecipe()
    {
        int randomIndex = random.Next(0, recipes.Count - 1);
        Recipe randomRecipe = recipes[randomIndex];
        return randomRecipe;
    }

    public void AddOrderToList(Order order)
    {
        matchStats.orders.Add(order);
    }

    // Main Methods
    public void CreateNewOrder()
    {

    }

    public void OnOrderComplete(Order order)
    {
        matchStats.orders.Remove(order);
        matchStats.score += order.recipe.points;
        // Calculate bonus
    }

    public void OnOrderTimeRunout(Order order)
    {
        matchStats.orders.Remove(order);
        matchStats.penalty += order.recipe.penalty;
    }

    void Update()
    {

    }

    /** Todo */
    // Watch for if order is complete
}
