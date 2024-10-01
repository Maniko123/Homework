using UnityEngine;

public class Painter : MonoBehaviour
{
    public void PaintCube(MeshRenderer meshRenderer)
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
