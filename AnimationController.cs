using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    Animation Anim;

    private void Awake()
    {
        Anim = GetComponent<Animation>();
    }
    public void Opendoor()
    {
        Anim.Play("open");
    }
    public void Closedoor()
    {
        Anim.Play("close");
    }
}

