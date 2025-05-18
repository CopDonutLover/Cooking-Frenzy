using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Random = System.Random;

public class Orders : MonoBehaviour
{
    // Resources
    Random random = new Random();
    List<Recipe> recipes = new List<Recipe>();
    MatchStats matchStats = GameObject.FindGameObjectWithTag("Resources").GetComponent<MatchStats>();
    Order orderTemplate = Resources.Load<Order>("Templates/Order");

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
        Order newOrder = Instantiate(orderTemplate).GetComponent<Order>();
        Recipe randomRecipe = GetRandomRecipe();
        newOrder.recipe = randomRecipe;
        AddOrderToList(newOrder);
    }

    public void OnOrderComplete(Order order)
    {
        matchStats.orders.Remove(order);
        matchStats.score += order.recipe.points;
        //TODO: Calculate bonus
    }

    public void OnOrderTimeRunout(Order order)
    {
        matchStats.orders.Remove(order);
        matchStats.penalty += order.recipe.penalty;
    }
}
