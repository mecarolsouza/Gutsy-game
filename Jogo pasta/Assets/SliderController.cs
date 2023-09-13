using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider slider; // Arraste o seu Slider para esta variável no Inspector

    private void Start()
    {
        // Configurar o valor inicial do slider (entre 0 e 1)
        slider.value = 0.5f; // Por exemplo, definimos para 50%
    }

    public void SetSliderValue(float newValue)
    {
        // Esta função permite definir o valor do slider de 0 a 1.
        slider.value = Mathf.Clamp01(newValue);
    }

    public float GetSliderValue()
    {
        // Esta função retorna o valor atual do slider de 0 a 1.
        return slider.value;
    }
}
