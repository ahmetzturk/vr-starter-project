using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColorRed()
    {
        meshRenderer.material.color = Color.red;
    }

    public void SetColorGreen()
    {
        meshRenderer.material.color = Color.green;
    }
}
