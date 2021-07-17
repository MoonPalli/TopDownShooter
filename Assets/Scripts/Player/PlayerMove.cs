using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private Transform _legs;
    [SerializeField] private Transform _pointToRatote;

    public void Move(PlayerInput input)
    {
        Vector2 moveValue = input.Player.Move.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(moveValue.x, moveValue.y);
        
        transform.position += moveDirection * _moveSpeed * Time.deltaTime;
        LookDirection(moveDirection);
    }

    private void LookDirection(Vector3 value)
    {
        _pointToRatote.position = transform.position + value;

        Vector3 lookDirection = _pointToRatote.position - transform.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        
        _legs.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}