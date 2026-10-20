using UnityEngine;

public class References : MonoBehaviour
{
    [SerializeField] private CoffeeShopMenuItems ItemChoosen;
    [SerializeField] private CoffeeShopData ItemPrice;

    private void Start()
    {
        float price = GetCoffeePrice(ItemPrice);

        Debug.Log($"{ItemPrice} costs £{price:F2}");
    }

    private float GetCoffeePrice(CoffeeShopMenuItems type)
    {
        switch (type)
        {
            case CoffeeShopMenuItems.Latte:
                return CoffeeShopData.LattePrice;
        }
    }
}
