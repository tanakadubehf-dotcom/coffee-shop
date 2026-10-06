using UnityEngine;

public class TestLessonScript : MonoBehaviour
{
    private int refills = 0;
    private int maxRefills = 3;

    void Start()
    {
        do
        {
            Debug.Log("Serving coffee refill number: " + (refills));
            refills++;
        }
        while (refills < maxRefills);
    }
}