using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    /// <summary>
    /// ���
    /// </summary>
    private void talkingmethod(string dialogue)
    {

    }
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    public bool openshop()
    {
        return true;
    }
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="price">�D�������100�A�Ǧ^�Ȭ�0</param>
    public int purchasething(int price = 100)
    {
        return 0;
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
    private int missionupdate(int mission = 1)
    {
        return 0;
    }
    /// <summary>
    /// ���ȧ���
    /// </summary>
    /// <param name="missionstatus">���Ȫ��A�w�]�Ȭ�false</param>
    /// <param name="missionnumber">���Ƚs��</param>
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
