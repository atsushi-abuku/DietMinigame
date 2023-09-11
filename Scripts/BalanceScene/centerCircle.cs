using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerCircle : MonoBehaviour
{
    public GameObject blmgr;
    public BalanceGameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3) {
            gm.clearTime -= Time.deltaTime;
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            gm.clearTime -= Time.deltaTime;
            
        }
    }

}
