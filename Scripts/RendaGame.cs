using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendaGame : MonoBehaviour
{
    public int rendaNum;
    
    // Start is called before the first frame update
    void Start()
    {
        rendaNum = 20;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rendaNum--;
        }
        if (rendaNum <= 0)
        {
           
        }
    }
}
