using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("基本能力"),Range(0,10)]
    public float speed = 3.5f;
    [Range(0, 500)]
    public float attack = 100;
    [Range(0,5000)]
    public float hp = 350;
    [Range(0,50)]
    public float rangeTrack = 50;
    public Vector3 offsetTrack;
    [Header("掉落道具")]
    public GameObject prop;
    [Range(0,1)]
    public float probability = 1;
    [Header("音效資料")]
    public AudioClip soundDropProp;
    public AudioClip soundHurt;
    public AudioClip soundAttack;

    private AudioSource aud;
    private Rigidbody rig;
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
