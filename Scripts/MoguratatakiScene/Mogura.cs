using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mogura : MonoBehaviour
{
    public MoguraGameManager mgmgr;
    // Start is called before the first frame update
    void Start()
    {
        mgmgr = GameObject.Find("moguraGameManager").GetComponent<MoguraGameManager>();
        //EventTriggerを設定する
        EventTrigger trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        // 右側の{}内に登録したい関数名を書く。
        entry.callback.AddListener((eventDate) => { mgmgr.Clear(); });
        trigger.triggers.Add(entry);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y > -1)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;

        }
    }
   public void sample()
    {

    }

}
