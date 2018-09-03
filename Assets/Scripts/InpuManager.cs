using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InpuManager : MonoBehaviour
{
    public static bool isGamePaused = false;
    public GameObject pauseMenu;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            { 
                pauseMenu.SetActive(false);
                isGamePaused = false;
                Time.timeScale = 1f;
            }
            else
            {
                
                pauseMenu.SetActive(true);
                isGamePaused = true;
                Time.timeScale = 0f;
            }
            
        }
    }
}
