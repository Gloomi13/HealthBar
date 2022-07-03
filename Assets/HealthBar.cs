using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;
    
    public void ChangeHealthBar(float number)
    {
        StartCoroutine(SmoothlyChangeHealthBar(number));
    }

    private void Start()
    {
        _slider.maxValue=_player.MaxHealth;
        _slider.value=_player.Health;
    }

        private IEnumerator SmoothlyChangeHealthBar(float number)
    {
        var waitForSeconds = new WaitForSeconds(0.05f);
        int speedChange = 10;

        for (int i = 0; i < speedChange; i++)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _slider.maxValue, number /speedChange);
            _slider.value = Mathf.Clamp(_slider.value, 0,_slider.maxValue);

            yield return waitForSeconds;
        }
    }
}
