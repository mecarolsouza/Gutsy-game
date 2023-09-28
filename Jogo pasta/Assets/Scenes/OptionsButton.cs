using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public GameObject pauseMenu;

    private void Start()
    {
        Button OptionsButton = GetComponent<Button>();
        OptionsButton.onClick.AddListener(ClosePauseMenu);
    }

    private void ClosePauseMenu()
    {
        pauseMenu.SetActive(false);
    }
}
