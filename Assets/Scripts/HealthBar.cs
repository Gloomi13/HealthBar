using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private float _speed = 1f;

    private void Start()
    {
        _slider.maxValue = _player.MaxHealth;
        _slider.value = _player.Health;
    }

    private void Change(float health)
    {
        StartCoroutine(SmoothlyChange(health));
    }

    private IEnumerator SmoothlyChange(float target)
    {
        var waitForSeconds = new WaitForSeconds(0.03f);

        while (_slider.value != target)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, target, _speed);

            yield return waitForSeconds;
        }
    }

    private void OnEnable()
    {
        _player.СhangeHealth += Change;
    }

    private void OnDisable()
    {
        _player.СhangeHealth -= Change;
    }
}
