using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTimeSeconds;

    private WaitForSeconds _waitForSeconds;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_lifeTimeSeconds);
    }

    private void OnEnable()
    {
        StartCoroutine(DestroyInTime());
    }

    private void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
            Destroy(gameObject);
        }
    }

    private IEnumerator DestroyInTime()
    {
        yield return _waitForSeconds;
        
        Destroy(gameObject);
    }
}