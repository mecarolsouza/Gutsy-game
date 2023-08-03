using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitPauseButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void ClosePauseMenu()
    {
    Time.timeScale = 1f; // Certifique-se de que o tempo volte ao normal ao fechar o menu de pausa
        SceneManager.UnloadScene("MenuPause"); // Fecha a cena "MenuPause"
    }

}