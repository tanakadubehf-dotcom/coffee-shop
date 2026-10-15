using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeShopData", menuName = "Coffee Data")]
public class CoffeeShopData : ScriptableObject
{
    public string CoffeeName;

    public Sprite Icon;

    public float quantity;

    public float value;

    public bool Instock;

    public CoffeeShopMenuItems ItemList;
}
