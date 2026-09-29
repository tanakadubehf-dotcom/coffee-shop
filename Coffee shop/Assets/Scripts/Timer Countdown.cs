using System.Collections;
using UnityEngine;

public class TimerCountdown : MonoBehaviour
{
    public int TimerNumber = 10;
    public int TimerNumCurrent;

    void Start()
    {
        StartCoroutine(MyCoroutineMethod());
    }

    IEnumerator MyCoroutineMethod()
    {
        while (TimerNumCurrent > 0)
        {
            yield return new WaitForSeconds(1f);
            TimerNumCurrent = TimerNumber - 1;
            Debug.Log("Timer: " + TimerNumCurrent);

            if (TimerNumCurrent <= 0)
            {
                Debug.Log("Timer has ended.");
            }
        }
    }
}