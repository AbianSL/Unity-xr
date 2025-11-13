using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer sphereRenderer;

    private void Start()
    {
        sphereRenderer = GetComponentInChildren<Renderer>();
    }

    public void ChangeToRed()
    {
        if (sphereRenderer != null)
            sphereRenderer.material.color = Color.red;
    }

    public void ChangeToWhite()
    {
        if (sphereRenderer != null)
            sphereRenderer.material.color = Color.white;
    }
}
