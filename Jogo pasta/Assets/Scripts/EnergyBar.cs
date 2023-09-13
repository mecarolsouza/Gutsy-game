using UnityEngine;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider energySlider; // Referência ao componente Slider da barra de energia

    // Método para definir a energia na barra de energia
    public void DefinirEnergia(int energia)
    {
        energySlider.value = energia; // Atualiza o valor do Slider para refletir a energia atual
    }
}
