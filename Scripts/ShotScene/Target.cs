using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public shotGameManager shtmgr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            shtmgr.touch_flg = true;
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
       
            shtmgr.touch_flg = true;
         
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        shtmgr.touch_flg = false;
    }
}
