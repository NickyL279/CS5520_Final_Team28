using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFlake : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check that the object we collided with is the player.
        if (other.gameObject.name == "player") {
            return;
        }

        // Add the volume of the snowball.

        // Destroy this snowflake object.
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
