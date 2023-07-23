using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour

{
    public Button backButton;
    public GameObject optionsMenu;

    private void Start()
    {
        backButton.onClick.AddListener(BackToMainMenu);
    }

    private void BackToMainMenu()
    {
        backButton.onClick.AddListener(BackToMainMenu);
        SceneManager.LoadScene("MainMenu");
    }
}

