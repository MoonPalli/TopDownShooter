using UnityEngine;

public class TestMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _ball;

    private PlayerInput _input;
    private Vector3 _targetPosition;

    private void Awake()
    {
        _input = new PlayerInput();
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
        var moveValue = _input.Player.Move.ReadValue<Vector2>();
        
        transform.position += (Vector3) moveValue * _speed * Time.deltaTime;
        _ball.position = transform.position + (Vector3) moveValue;

        var lookDirection = _ball.position - transform.position;
        transform.up = lookDirection;
    }
}