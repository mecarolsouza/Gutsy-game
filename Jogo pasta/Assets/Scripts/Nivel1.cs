using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel1 : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject Letter1;

    private void Start()
    {
       pauseMenu.SetActive(false);
       Letter1.SetActive(false);
    }

    private void Update()
    {
        // Verifica se o botão "Esc" foi pressionado
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Carrega a cena "MenuPause"
            pauseMenu.SetActive(true);

            // Pausa o jogo
            Time.timeScale = 0f;
        }
    }
}


