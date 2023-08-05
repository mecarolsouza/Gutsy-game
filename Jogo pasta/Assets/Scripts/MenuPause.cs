using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaused = false;

    private void Update()
    {
        // Verifica se o botão "Esc" foi pressionado
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Pausa o jogo
        isPaused = true;
        pauseMenu.SetActive(true); // Ativa o menu de pausa
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Volta ao tempo normal
        isPaused = false;
        pauseMenu.SetActive(false); // Desativa o menu de pausa
    }

    public void Settings()
    {
        // Carrega a cena "OptionsMenu"
        SceneManager.LoadScene("OptionMenu");
    }

    public void QuitMenuPause()
    {
        // Implemente aqui a lógica para sair do menu de pausa e retornar ao jogo
        ResumeGame();
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1f; // Certifique-se de que o tempo volte ao normal ao sair do menu de pausa
        SceneManager.LoadScene("MainMenu"); // Substitua "MainMenu" pelo nome da cena do menu principal
    }

}
