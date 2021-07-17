using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickerCar : MonoBehaviour
{
    // Start is called before the first frame update
    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;
    void Start()
    {
        renderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BlueColor()
    {
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }
    public void OrangeColor()
    {
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    public void GreenColor()
    {
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }
    public void FresnelColor()
    {
        renderer.material = BodyColorMat[3];
        CurrMat = renderer.material;
    }
    public void HologramColor()
    {
        renderer.material = BodyColorMat[4];
        CurrMat = renderer.material;
    }

}
