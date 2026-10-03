using UnityEngine;

public class RandomDice6sides : MonoBehaviour
{
    public int RandomNumber;
    void Update()
    {
        RandomNumber = Random.Range(1, 6);

        if (Input.GetKeyDown(KeyCode.R))
            Debug.Log("Numberpicked:" + RandomNumber + "Normal hit");
        else if (RandomNumber == 6)
            Debug.Log("Crit");

    }
}
