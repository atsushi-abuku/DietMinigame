using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalanceGameManager : MonoBehaviour
{
    public float clearTime;
    public TMPro.TextMeshProUGUI clearTmp;
    // Start is called before the first frame update
    void Start()
    {
        clearTime = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(clearTime <= 0)
        {
            clearTmp.text = "CLEAR";
            
        }
    }
}
