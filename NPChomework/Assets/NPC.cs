using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    /// <summary>
    /// 對話
    /// </summary>
    private void talkingmethod(string dialogue)
    {

    }
    /// <summary>
    /// 開啟商店
    /// </summary>
    public bool openshop()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="price">道具金錢為100，傳回值為0</param>
    public int purchasething(int price = 100)
    {
        return 0;
    }
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <returns>任務編號</returns>
    public string getmission()
    {
        return "任務編號";
    }
    /// <summary>
    /// 任務更新
    /// </summary>
    /// <param name="mission">獲得任務道具數量預設為1</param>
    private int missionupdate(int mission = 1)
    {
        return 0;
    }
    /// <summary>
    /// 任務完成
    /// </summary>
    /// <param name="missionstatus">任務狀態預設值為false</param>
    /// <param name="missionnumber">任務編號</param>
    private bool missioncomplete(int indexmission)
    {
        return false;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
