using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Part
{
    public GameObject weaponGo;
    public Transform weaponInitPos;
    public override void ActiveSpecial(){
        GameObject.Instantiate(weaponGo,weaponInitPos.position,Quaternion.identity);
    }

    public override void Death(){
        
    }
}
