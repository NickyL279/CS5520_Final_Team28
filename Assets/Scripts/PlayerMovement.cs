using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    public Rigidbody rb;

    public float horizontalMultiplier = 2; 

    float horizontalInput;

    public void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
                horizontalInput = 1;
            else
                horizontalInput = -1;
        }
    }
}
