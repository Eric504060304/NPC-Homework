using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    /// <summary>
    /// 對話
    /// </summary>
    private void talkingmethod()
    {

    }
    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns>true</returns>
    public bool openshop()
    {
        return true;
    }
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="price">道具金錢為100，傳回值為0</param>
    public void purchasething(int price = 100)
    {
        purchasething(0);
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
    private void missionupdate(int mission = 1)
    {
        missionupdate(0);
    }
    /// <summary>
    /// 任務完成
    /// </summary>
    /// <param name="missionstatus">任務狀態預設值為false</param>
    /// <param name="missionnumber">任務編號</param>
    private void missioncomplete(bool missionstatus, string missionnumber)
    {
        missioncomplete(false, "任務編號");

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
