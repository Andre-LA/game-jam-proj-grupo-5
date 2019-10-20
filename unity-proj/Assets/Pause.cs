using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GamePausado = false;
    public GameObject MenuPauseUI;
    void Start()
    {
        MenuPauseUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (GamePausado)
            {
                Resume();
            
            }
            else
            { Pausea();   }
        }
    }

    public void Resume()
    {
        MenuPauseUI.SetActive(false);
        Time.timeScale = 1;
        GamePausado = false;
        
    }
    public void Pausea()
    {
        MenuPauseUI.SetActive(true);
        Time.timeScale = 0;
        GamePausado = true;
    }
}
