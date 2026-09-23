using UnityEngine;

public class CalculatingValues : MonoBehaviour
{
    public int n = 24;

    private int CalulateForN;

    public int CurrentValue;

    void Start()
    {
        n = 4;

        CalculateForN(n);
    }

    void CalculateForN(int n)
    {
        CurrentValue = n * 3;

        Debug.Log("The current value is: " + CurrentValue);
    }

}