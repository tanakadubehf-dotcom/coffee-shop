using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{
    bool CoffeeMachineOn = true;

    void Start()
    {
        if (CoffeeMachineOn)
        {
            Debug.Log("Coffee brewing...");
        }
    }
}