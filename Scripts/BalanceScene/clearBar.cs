using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class clearBar : MonoBehaviour
{
    public BalanceGameManager bmgr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Image>().fillAmount = (2 - bmgr.clearTime) / 2;
    }
}
