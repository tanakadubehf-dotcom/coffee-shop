using System.Collections;
using UnityEngine;

public class Coroutine : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(MakeCoffee());
    }
    private IEnumerator MakeCoffee()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("coffeeReady!");
    }

}
