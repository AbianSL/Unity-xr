using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnPointerEnter()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    void OnPointerExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
