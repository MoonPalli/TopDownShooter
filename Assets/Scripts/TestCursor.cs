using UnityEngine;
using System.Collections.Generic;

public class TestCursor : MonoBehaviour
{
    [SerializeField] private int _count;
    [SerializeField] private float _radius;
    [SerializeField] private GameObject _container;
    [SerializeField] private GameObject _sightRiskPrefab;

    private List<GameObject> _sightRisks = new List<GameObject>();

    private void Awake()
    {
        for (int i = 0; i < _count; i++)
        {
            GameObject obj = Instantiate(_sightRiskPrefab, _container.transform);

            _sightRisks.Add(obj);
        }

        for (int i = 0; i < _sightRisks.Count; i++)
        {
            float theta = i * 2 * Mathf.PI / _count;
            float x = Mathf.Sin(theta) * _radius;
            float y = Mathf.Cos(theta) * _radius;

            Vector3 newPos = new Vector3(x, y, 0);

            _sightRisks[i].transform.position = newPos;
        }

        ChangeSize();
    }

    private void ChangeSize()
    {
        for (var i = 0; i < _sightRisks.Count; i++)
        {
            var spriteRenderer = _sightRisks[i].GetComponent<SpriteRenderer>();
            spriteRenderer.size = new Vector2(0.5f, 0.5f);
        }
    }
}