using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    //float time;
    public GameObject target;
    public int direct;
    // Start is called before the first frame update
    void Start()
    {
        direct = -1;
        //time = 1;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y < -3)
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0,0); 
            direct = 1;
        }
        else if (transform.position.y > 3)
        {
            GetComponent<Rigidbody2D>().velocity += new Vector2(0, 0);
            direct = -1;
        }
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2*direct);
    }


}
