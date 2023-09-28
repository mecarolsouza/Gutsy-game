using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nivel2 : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu;
    
    private void Start()
    {
        // Deactivate the pauseMenu GameObject at the start of the game
        pauseMenu.SetActive(false);
    }
    
    private void Update()
    {
        // Verifica se o botão "Esc" foi pressionado
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            
                pauseMenu.SetActive(true);
            
            
        }
    }
}
