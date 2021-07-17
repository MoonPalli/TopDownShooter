using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(SpriteRenderer))]
public class CursonSetter : MonoBehaviour
{
    private Camera _camera;
    private Vector2 _mousePosition;

    private void Awake()
    {
        _camera = Camera.main;
        Cursor.visible = true;
    }

    private void Update()
    {
        _mousePosition = _camera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = _mousePosition;
    }
}