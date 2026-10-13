using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour, Iclickable
{
    private NpcList otherScript;
    void Start()
    {
        otherScript = GetComponent<NpcList>();
    }
    [SerializeField] private UnityEvent onClick;

    public void OnClick()
    {
        
        onClick?.Invoke();
        Debug.Log(otherScript);
    }
}
