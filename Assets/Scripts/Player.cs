using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;

    public UnityAction<float> onChangeHealth;

    private void Awake()
    {
        _health = 80;
        _maxHealth = 100;
    }

    public void HealPlayer(float heal)
    {
        _health = Mathf.Clamp(_health + heal, 0, _maxHealth);
        onChangeHealth?.Invoke(_health);
    }

    public void DamagePlayer(float damage)
    {
        _health = Mathf.Clamp(_health - damage, 0, _maxHealth);
        onChangeHealth?.Invoke(_health);
    }

    public float MaxHealth=> _maxHealth;

    public float Health => _health;

}
