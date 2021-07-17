using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bottombartoggle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject RawImage;

    public void openRawImage()
    {
        if(RawImage != null)
        {
            bool isActive = RawImage.activeSelf;
            RawImage.SetActive(!isActive);
        }
    }
}
