using UnityEngine;

public class OrderingSystem : MonoBehaviour
{
    public float _costOfCoffee = 4;
    
    public int coffeeAmountOrdered;

    public float totalOrderedAmount; 

    public void AmountPlaced(int coffeeAmountOrdered)
    {
      totalOrderedAmount = coffeeAmountOrdered * _costOfCoffee;

      Debug.Log("The total amount ordered is: " + totalOrderedAmount);
    }
}
//access modifiers
//void -> private void
//void
//public void -> public void
//if public can  be seen outside class (script)
//if private, cant be seen outside class (script)