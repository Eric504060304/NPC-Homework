using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    /// <summary>
    /// ���
    /// </summary>
    private void talkingmethod()
    {

    }
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns>true</returns>
    public bool openshop()
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="price">�D�������100�A�Ǧ^�Ȭ�0</param>
    public void purchasething(int price = 100)
    {
        purchasething(0);
    }
    /// <summary>
    /// ���o����
    /// </summary>
    /// <returns>���Ƚs��</returns>
    public string getmission()
    {
        return "���Ƚs��";
    }
    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <param name="mission">��o���ȹD��ƶq�w�]��1</param>
    private void missionupdate(int mission = 1)
    {
        missionupdate(0);
    }
    /// <summary>
    /// ���ȧ���
    /// </summary>
    /// <param name="missionstatus">���Ȫ��A�w�]�Ȭ�false</param>
    /// <param name="missionnumber">���Ƚs��</param>
    private void missioncomplete(bool missionstatus, string missionnumber)
    {
        missioncomplete(false, "���Ƚs��");

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
