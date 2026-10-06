using UnityEngine;
using System.Collections;

public class ClickObject2 : MonoBehaviour
{
    public float[] values;

    void Start()
    {
        foreach (float value in values)
        {
            Debug.Log(value);
        }

        values = new float[5];

        values[1] = 5.0f;
    }
}