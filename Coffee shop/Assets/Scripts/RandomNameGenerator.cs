using UnityEngine;

public class RandomNameGenerator : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Debug.Log("random name picked:" + names[Random.Range(0, names.Length)]);
    }
    public static string[] names = new string[5];
    void Start()
    {
        names[0] = "name1";
        names[1] = "name2";
        names[2] = "name3";
        names[3] = "name4";
        names[4] = "name5";
        if (names == null)
            Debug.LogWarning("Could not find random name list");
      
    } }
        