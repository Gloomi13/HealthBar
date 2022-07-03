using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Slider slider;
    
    public void ChangeHealthBar(float number)
    {
        StartCoroutine(SmoothlyChangeHealthBar(number));
    }

    private void Start()
    {
        slider.maxValue=player.MaxHealth;
        slider.value=player.Health;
    }

        private IEnumerator SmoothlyChangeHealthBar(float number)
    {
        var waitForSeconds = new WaitForSeconds(0.05f);
        int speedChange = 10;

        for (int i = 0; i < speedChange; i++)
        {
            slider.value = Mathf.MoveTowards(slider.value, slider.maxValue, number /speedChange);
            slider.value = Mathf.Clamp(slider.value, 0,slider.maxValue);

            yield return waitForSeconds;
        }
    }
}
