using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _secondsToWait;
    [SerializeField] private Color _targetColor;

    private SpriteRenderer _spriteRenderer;
    private WaitForSeconds _waitForSeconds;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_secondsToWait);
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        
        StartCoroutine(ChangeColorOnHit());

        if (_health <= 0)
            gameObject.SetActive(false);
    }

    private IEnumerator ChangeColorOnHit()
    {
        Color baseColor = _spriteRenderer.color;

        _spriteRenderer.color = _targetColor;
        
        yield return _waitForSeconds;
        
        _spriteRenderer.color = baseColor;
    }
}