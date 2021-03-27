using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ingredient List", menuName = "Creperia/Ingredient List", order = 1)]
public class IngredientList : ScriptableObject
{
    public List<Ingredient> Ingredients = new List<Ingredient>();
}
