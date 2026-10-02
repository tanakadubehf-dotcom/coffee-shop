using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Iclickable clickable =
                    hit.collider.GetComponent<Iclickable>();

                clickable?.OnClick();
            }
        }
    }
}
