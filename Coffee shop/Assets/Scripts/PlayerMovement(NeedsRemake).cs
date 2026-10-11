using UnityEngine;

public class PlayerMovementCC : MonoBehaviour
{
    public float speed = 5f;

    // these cant be used because i cant make gravity work.
    //there might also be a newer input system that i dont know about.
    public float jump = -2f;
    public float gravity = -9.81f;

    private CharacterController cc;
    private Vector3 velocity;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        cc.Move(move * speed * Time.deltaTime);

        cc.Move(velocity * Time.deltaTime);
    }
}