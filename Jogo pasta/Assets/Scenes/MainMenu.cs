using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        // Aqui você pode colocar a lógica para iniciar o jogo ou carregar a primeira cena do jogo
        SceneManager.LoadScene("Game");
    }

    public void OpenOptions()
    {
        // Aqui você pode colocar a lógica para abrir as opções do jogo
        SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitGame()
    {
         Application.Quit();
    }
}
