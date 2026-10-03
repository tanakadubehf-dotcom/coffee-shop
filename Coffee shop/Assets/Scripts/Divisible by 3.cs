using Unity.VisualScripting;
using UnityEngine;

public class Divisibleby3 : MonoBehaviour
{

    public int Dividend = 35;
    [SerializeField] private int Divisor = 3;
    [SerializeField] private bool ModuloValue;

    public void Calculate()
    {
        if (ModuloValue = Dividend % Divisor == 0)
        {
            ModuloValue = true;
            Debug.Log("The number is divisible by 3");
        }
        else
        {
            ModuloValue = false;
            Debug.Log("The number is not divisible by 3");
        }

    }

}
