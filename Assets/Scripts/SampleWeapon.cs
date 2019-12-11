using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleWeapon : MonoBehaviour
{
    public bool trackingWeapon = false;
    public KeyCode myKey;
    public float Damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (myKey)) {
            ActiveWeapon();
        }
    }

    void ActiveWeapon(){
        if(trackingWeapon){
            Tracking();
        }else{
            UnTracking();       
        }
    }

    void Tracking(){
        //TODO:追踪导弹
    }

    void UnTracking(){
        //TODO:非追踪导弹
    }
}
