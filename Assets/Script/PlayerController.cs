using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        Moving();
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Duck();
        }
    }

    // Update is called once per frame
    void Moving()
    {

    }
    void Duck()
    {

    }
    void Jump()
    {

    }
}
