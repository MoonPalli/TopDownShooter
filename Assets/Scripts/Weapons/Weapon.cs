using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _damage;
    [SerializeField] private int _clipCapacity;

    [SerializeField] protected Bullet bullet;

    public abstract void Shoot();
    public abstract void Reload();
}