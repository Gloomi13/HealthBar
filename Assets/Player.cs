using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float _health { get; private set; }
    public float _maxHealth { get; private set; }

    public void HealPlayer(float _heal)
    {
        if (_health < 100)
        {
        StartCoroutine(ChangeHealth(_heal));
        }

        if (_health > 100)
            _health = 100;
    }

    public void DamagePlayer(float _damage)
    {
        if (_health > 0)
           {
           StartCoroutine(ChangeHealth(_damage));
           }

        if (_health < 0)
            _health = 0;
    }
    
    private void Awake()
    {
        _health = 80;
        _maxHealth = 100;
    }

    private IEnumerator ChangeHealth(float number)
    {
        var waitForSeconds = new WaitForSeconds(0.05f);
        int speedChange = 10;

        for(int i=0; i< speedChange;i++)
        {
            _health=Mathf.MoveTowards(_health,_maxHealth,number/speedChange);

            yield return waitForSeconds;
        }
    }
}
