using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    public Joystick Lompat;
    public float Force;
    bool Lompatcuy = false;

    // Update is called once per frame
    void Update()
    {
        float verticalMove = Lompat.Vertical;

        if (verticalMove >= .5f)
        {
            Lompatcuy = true;
        }
    }
}
