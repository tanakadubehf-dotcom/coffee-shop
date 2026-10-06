using UnityEngine;

public class MiniCoffeeShop : MonoBehaviour
{
    public int CoffeeCups = 1;

    public int Serving = 1;


    void Update()
    {
        Input.GetKey(KeyCode.Y);

        for (int CoffeeCups =1; CoffeeCups <= 10; CoffeeCups++)
        {
            if (CoffeeCups != 10)
            {
                Debug.Log("Not ready");
            }
            else
            {
                Debug.Log("ready");
            }
        }
    }
}