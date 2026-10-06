using UnityEngine;

public class CoffeeIFELSE : MonoBehaviour
{
    int sugarLevel = 2;
    void Start()
    {
        if (sugarLevel == 1)
        {
            Debug.Log("You have selected 1 sugar level");
        }
        else if (sugarLevel == 2)
        {
            Debug.Log("You have selected 2 sugar levels");
        }
        else if (sugarLevel == 3)
        {
            Debug.Log("You have selected 3 sugar levels");
        }
        else
        {
            Debug.Log("You have not selected a sugar level");
        }
    }
}