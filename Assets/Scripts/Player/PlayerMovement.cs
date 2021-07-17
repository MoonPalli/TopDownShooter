using UnityEngine;

[RequireComponent(typeof(PlayerMove), typeof(PlayerAim), typeof(PlayerShoot))]
public class PlayerMovement : MonoBehaviour 
{
    private PlayerInput _input;
    private PlayerMove _playerMove;
    private PlayerAim _playerAim;
    private PlayerShoot _playerShoot;

    private void Awake()
    {
        _input = new PlayerInput();;
        
        _playerMove = GetComponent<PlayerMove>();
        _playerAim = GetComponent<PlayerAim>();
        _playerShoot = GetComponent<PlayerShoot>();
        
        _input.Player.Shoot.performed += ctx => _playerShoot.OnShoot();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Update()
    {
        _playerAim.Aim(_input);
        _playerMove.Move(_input);
    }
}