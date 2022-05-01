using UnityEngine;

public class Fire : MonoBehaviour
{
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        // Check that the object we collided with is the player.
        if (other.gameObject.name != "Player") {
            return;
        }

        Vibrator.Vibrate();
        // Add the volume of the snowball.
        Vector3 currentScale = other.gameObject.transform.localScale;

        if (other.gameObject.localScale.magnitude < 0.0000005f)
        {
            other.gameObject.PlayerMovement.Die();
        } else {
            other.gameObject.transform.localScale = new Vector3(0.9f * currentScale.x,
         0.9f * currentScale.y, 0.9f * currentScale.z);

        // Destroy this snowflake object.
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
