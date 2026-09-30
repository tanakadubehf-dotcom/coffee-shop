using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : MonoBehaviour, Iclickable
{
    [SerializeField] private UnityEvent onClick;

    public void OnClick()
    {
        onClick?.Invoke();
        Debug.Log("found clickable object");
    }
}
