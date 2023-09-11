using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(new Vector3(0, 0, 0.4f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(new Vector3(0, 0, -0.4f));
        }
    }
}
