using UnityEngine;

public class TestAim : MonoBehaviour
{
    private Camera _camera;
    private PlayerInput _input;

    private void Awake()
    {
        _camera = Camera.main;
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
        Vector2 mouseValue = _input.Player.Aim.ReadValue<Vector2>();
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(mouseValue);

        Vector3 targetDirection = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}