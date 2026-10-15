using UnityEngine;

public enum CoffeeShopMenuItems
{
    Latte,
    Black_Coffee,
    Donut,
    None
}

public class CoffeeMenu : ScriptableObject
{
    [SerializeField] private CoffeeShopMenuItems[] ShopMenu;
}
