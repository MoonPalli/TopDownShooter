using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void Update()
    {
        Vector3 position = _target.position;
        Vector3 targetPos = new Vector3(position.x, position.y, transform.position.z);
        
        transform.position = targetPos;
    }
}