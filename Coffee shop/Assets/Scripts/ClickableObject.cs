using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour, Iclickable
{
    private TimerCountdown ScriptTwo;
    private NpcList otherScript;
    void Start()
    {
        ScriptTwo = GetComponent<TimerCountdown>();
        otherScript = GetComponent<NpcList>();
    }
    [SerializeField] private UnityEvent onClick;

  

    public void OnClick()
    {
        
        onClick?.Invoke();
        Debug.Log("clicking is working");
    }
}
