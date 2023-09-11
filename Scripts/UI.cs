using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
   
    public GameObject mgr;
    public RendaGame renda;
    // Start is called before the first frame update
    void Start()
    {
        renda = mgr.GetComponent<RendaGame>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "kaisuu:"+renda.rendaNum;

        if (renda.rendaNum <= 0)
        {
            GetComponent<TextMeshProUGUI>().text = "CREAR!!";
        }
    }
}
