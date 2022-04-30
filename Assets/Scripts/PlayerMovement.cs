using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool isAlive = true;
    public GameObject GameLoss;
    public float speed = 5;
    
    public Rigidbody rb; 
    
    float horizontalInput;
    
    public float horizontalMultiplier = 2;
    

    public void FixedUpdate()
    {
        if (!isAlive) 
            return;
        
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        
        if (transform.position.y < 0) 
        {
            Die();
        }
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
    
    public void Die ()
    {
        isAlive = false;
        GameLoss.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Restart the game;
        // Vibrator.Vibrate();
        // Invoke("Restart", 2);
    }
}
