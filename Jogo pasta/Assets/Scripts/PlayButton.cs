using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private void Start()
    {
        Button playButton = GetComponent<Button>();
        playButton.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
         // Desativa a cena MainMenu
        GameObject mainMenu = GameObject.Find("MainMenu"); // Certifique-se de que o objeto que representa a cena MainMenu tenha o nome "MainMenu"
        if (mainMenu != null)
        {
            mainMenu.SetActive(false);
        }
        SceneManager.LoadScene("Nível 1");
    }
}