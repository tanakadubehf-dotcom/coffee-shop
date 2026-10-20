using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeShopData", menuName = "EditableData")]
public class CoffeeShopData : ScriptableObject
{

    public float espressoPrice;

    public Sprite Icon;

    public float quantity;

    public float value;

    public bool Instock;

    public CoffeeShopMenuItems ItemList;

    public float LattePrice = 2.00f;
    
    public float BCoffeePrice = 3.00f;
    
    public float DonutPrice = 2.50f;

    public float NoneP = 0.00f;
}
