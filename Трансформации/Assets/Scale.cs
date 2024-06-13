using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale = transform.localScale + new Vector3(0.5f,0.5f,0.5f) * _speed;
    }
}