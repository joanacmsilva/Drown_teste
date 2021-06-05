using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravidade : MonoBehaviour
{
    public bool gravitySwitch;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravitySwitch = !gravitySwitch;

            if (gravitySwitch)
            {
                Physics.gravity = new Vector3(0, 1, 0);
            }
            else if (!gravitySwitch)
            {
                Physics.gravity = new Vector3(0, -1, 0);
            }
        }
    }
}