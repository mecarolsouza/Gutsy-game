using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    private void Start()
    {
        Button OptionsButton = GetComponent<Button>();
        OptionsButton.onClick.AddListener(OpenOptions);
    }

    private void OpenOptions()
    {
        SceneManager.LoadScene("OptionMenu");
    }
}