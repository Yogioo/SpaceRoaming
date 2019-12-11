using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Part {
    public Vector2 rotateAngle;
    public float rotateSpeed;

    public Transform[] initPos;
    public GameObject bulletPre;
    public KeyCode key;
    public bool isActiveWeapon;

    void Update () {

        if (Input.GetKeyDown (key)) {
            isActiveWeapon = true;
        }
        if (isActiveWeapon) {
            ActiveWeapon ();
        }
        ClampRotateAngle(rotateAngle.x,rotateAngle.y);
    }

    private void ClampRotateAngle (float minAngle, float maxAngle) {
        Vector3 eulerAngle = transform.localEulerAngles;
        Debug.Log(CheckAngle(eulerAngle.z));
        if(CheckAngle(eulerAngle.z )> maxAngle)
        {
            eulerAngle.z = maxAngle;
        }else if(CheckAngle(eulerAngle.z ) < minAngle){
            eulerAngle.z = minAngle;
        }

        transform.localEulerAngles = eulerAngle;
    }

    public float CheckAngle(float value)  // 将大于180度角进行以负数形式输出
    {
        float angle = value - 180;  

        if (angle > 0)
        {
            return angle - 180;
        }

        if (value == 0)
        {
            return 0;
        }

        return angle + 180;
    }

    public virtual void ActiveWeapon () {
        for (int i = 0; i < initPos.Length; i++) {
            GameObject.Instantiate (bulletPre, initPos[i].position, Quaternion.identity);
        }
    }


}