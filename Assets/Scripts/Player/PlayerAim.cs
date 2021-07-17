using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    [SerializeField] private Transform _body;
    
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }
    
    public void Aim(PlayerInput input)
    {
        Vector2 mouseValue = input.Player.Aim.ReadValue<Vector2>();
        Vector3 mouseWorldPosition = _camera.ScreenToWorldPoint(mouseValue);

        Vector3 lookDirection = mouseWorldPosition - transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        
        _body.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}