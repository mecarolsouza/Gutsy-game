using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider energySlider; // Arraste o seu Slider para esta variável no Inspector

    private void Start()
    {
        // Configurar o valor inicial do slider (entre 0 e 1)
        energySlider.value = 50f; // Por exemplo, definimos para 50%
    }

    public void SetSliderValue(float newValue)
    {
        // Esta função permite definir o valor do slider de 0 a 1.
        energySlider.value = Mathf.Clamp01(newValue);
    }

    public float GetSliderValue()
    {
        // Esta função retorna o valor atual do slider de 0 a 1.
        return energySlider.value;
    }
}
