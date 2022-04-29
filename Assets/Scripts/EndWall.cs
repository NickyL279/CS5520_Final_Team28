using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //check the object we collided with is the player
        if(other.gameObject.name != "Player"){
            return;
        }
        //Add to the player's score
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Destory this coin
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
