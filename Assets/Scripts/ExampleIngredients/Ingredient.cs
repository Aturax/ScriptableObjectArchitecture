using UnityEngine;


[CreateAssetMenu(fileName = "New Ingredient", menuName = "Creperia/Ingredient", order = 1)]
public class Ingredient: ScriptableObject
{
    public string Description;
    public Sprite Sprite;
}
