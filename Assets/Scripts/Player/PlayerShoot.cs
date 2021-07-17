using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _shootPosition;

    public void OnShoot()
    {
        Instantiate(_bullet, _shootPosition.position, _shootPosition.rotation);
    }
}