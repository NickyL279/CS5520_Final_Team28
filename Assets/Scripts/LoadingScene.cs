using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    // public Text loadingText;
    public Image progressBar;
    private int curProgressValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        int progressValue = 100;

        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }

        // loadingText.text = "Loading... " + curProgressValue + "%";

        progressBar.fillAmount = curProgressValue / 100f;

        if (curProgressValue == 100)
        {
            // loadingText.text = "Done";
            SceneManager.LoadScene("MenuScene");
        }
    }

}
