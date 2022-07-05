using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth;

    public event UnityAction<float> СhangeHealth;

    private void Awake()
    {
        _health = 80;
        _maxHealth = 100;
    }

    public void Heal(float heal)
    {
        _health = Mathf.Clamp(_health + heal, 0, _maxHealth);
        СhangeHealth?.Invoke(_health);
    }

    public void Damage(float damage)
    {
        _health = Mathf.Clamp(_health - damage, 0, _maxHealth);
        СhangeHealth?.Invoke(_health);
    }

    public float MaxHealth => _maxHealth;

    public float Health => _health;
}
