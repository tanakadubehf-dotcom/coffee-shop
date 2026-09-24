using UnityEngine;
using UnityEngine.Events;

public class Costomer : MonoBehaviour
{
    public string drinkType = "Coffee";
    public UnityEvent raiseOrder;

    void Start()
    {
        RequestDrink(drinkType);
    }

    public void RequestDrink(string drinkType)
    {
        Debug.Log("The drink type is: " + drinkType);
        raiseOrder?.Invoke();
    }
}