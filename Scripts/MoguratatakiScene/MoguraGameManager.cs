using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraGameManager : MonoBehaviour
{
    public GameObject mogura;
    public GameObject hazure;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(mogura, new Vector3(Random.Range(-10, 10), -2.4f, 0), Quaternion.identity);
        for (int i = 0; i < 2; i++)
        {
            Instantiate(hazure,new Vector3(Random.Range(-10,10),-2.4f,0),Quaternion.identity);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clear()
    {
        Debug.Log("CLEAR");
    }

    public void GAMEOVER()
    {
        Debug.Log("GAMEOVER");
    }
}
