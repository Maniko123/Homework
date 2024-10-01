using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private LayerMask _layerMask;
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(_camera.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo, float.MaxValue, _layerMask.value))
            {
                if (hitInfo.collider.TryGetComponent(out CubeStats cubeStats))
                {
                    _spawner.MultiplyCubes(hitInfo, cubeStats);
                }
            }
        }
    }
}
