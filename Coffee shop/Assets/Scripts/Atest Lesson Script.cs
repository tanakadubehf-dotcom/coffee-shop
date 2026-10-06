using UnityEngine;

public class AtestLessonScript : MonoBehaviour
{
    [SerializeField]
    private string[] coffeeMenu = { "Espresso", "latte", "Cappuccino", "Americano", "Mocha"};

    void Start()
    {
        foreach (string coffee in coffeeMenu)
        {
            Debug.Log("coffee menu: " + coffee);
        }
    }
}
