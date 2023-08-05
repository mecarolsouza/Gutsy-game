using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    public void Start()
    {
        Button quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(QuitGame);
    }

    public void QuitGame()
    {
        Debug.Log("Quit"); // Display the message "Quit" in the console
        Application.Quit(); // Quit the application when the Quit button is clicked
    }
}