using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel1 : MonoBehaviour
{
    private MenuPause menuPause;

    private void Start()
    {
       
    }

    private void Update()
    {
       
        // Verifica se o botão "Esc" foi pressionado
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Carrega a cena "MenuPause"
            SceneManager.LoadScene("MenuPause", LoadSceneMode.Additive);

            // Pausa o jogo
            Time.timeScale = 0f;
        }
    }

}
