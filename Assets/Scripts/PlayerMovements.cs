using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovements : MonoBehaviour
{
    bool isAlive = true;
    public GameObject GameLoss;

    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    private void FixedUpdate()
    {
        if (!isAlive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

        horizontalInput = Input.GetAxis("Horizontal"); 

        if (transform.position.y < 0) 
        {
            Die();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        GameLoss.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        // if (isAlive){
        //     horizontalInput = Input.GetAxis("Horizontal"); 

        //     if (transform.position.y < 0) 
        //     {
        //         Die();
        //     }
        // }
    }

    public void Die ()
    {
        isAlive = false;
        GameLoss.SetActive(true);
        // Restart the game;
        // Vibrator.Vibrate();
        // Invoke("Restart", 2);
    }

    void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
