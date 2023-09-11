using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shotGameManager : MonoBehaviour
{
    public bool touch_flg;
    public bool shot_flg;
    public GameObject player;
    public Sprite player_yumi2;
    public TMPro.TextMeshProUGUI clearTmp;

    // Start is called before the first frame update
    void Start()
    {
       
        touch_flg = false;
        shot_flg = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !shot_flg)
        {
            player.GetComponent<SpriteRenderer>().sprite = player_yumi2;
            shot_flg = true;
            if (touch_flg)
            {
                clearTmp.text = "CREAR!";
            }
            else
            {
                clearTmp.text = "GAMEOVER!";
            }
        }
    }
}
