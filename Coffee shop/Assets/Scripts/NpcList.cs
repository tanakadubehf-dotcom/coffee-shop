using UnityEngine;


public class NpcList : MonoBehaviour, Iclickable
{

    public int RngPick;

    public float CostomerRngTip;

    public string[] NpcNumber = new string[5];
    void Start()
    {
        NpcNumber[0] = "Costomer1";
        NpcNumber[1] = "Costomer2";
        NpcNumber[2] = "Costomer3";
        NpcNumber[3] = "Costomer4";
        NpcNumber[4] = "Costomer5";
        if (NpcNumber == null)
            Debug.LogWarning("Could not find Npc list");
    }

    public void OnClick()
    {
        RngPick = Random.Range(0, NpcNumber.Length);
        CostomerRngTip = Random.Range(1f, 5f);
        Debug.Log(NpcNumber[RngPick] + " They tip: " + CostomerRngTip);
    }

}

