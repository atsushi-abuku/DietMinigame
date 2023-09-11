using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector2(Random.Range(-3.5f, 3.5f), 0.25f);
        while (this.transform.position.x > -0.2f && this.transform.position.x < 0.2f)
        {
            this.transform.position = new Vector2(Random.Range(-3.5f, 3.5f), 0.25f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
