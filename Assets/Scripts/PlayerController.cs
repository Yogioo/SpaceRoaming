using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rigid;

    public float horizontalSpeed = 1;
    public float verticalSpeed = 1;
    public Vector3 direction = Vector3.zero;
    public float moveIntinsity = 0;
    public SamplerEngine[] engines;

    private Vector3 maxDir = Vector3.zero;
    float rotateSpeed = 20;

    void Awake () {
        rigid = GetComponent<Rigidbody2D> ();

    }

    void Start () {
        engines = GetComponentsInChildren<SamplerEngine> ();
    }

    void FixedUpdate () {
        Look ();
    }

    void Look () {
        // Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        // mousePos.z = 0;
        // Vector3 lookDir = mousePos - transform.position;
        // lookDir.z = 0;
        // lookDir = Vector3.Normalize (lookDir);
        // direction = lookDir;
    }

    // void MoveController () {
    //     float h = Input.GetAxis ("Horizontal");
    //     float v = Input.GetAxis ("Vertical");
    //     if (v != 0 || h != 0) {
    //         direction = new Vector3 (h, v, 0);
    //         //direction = Vector3.Normalize (direction);
    //     } else {
    //         direction = Vector3.zero;
    //     }

    //     float totalMoveIntinsity = 0;

    //     for (int i = 0; i < engines.Length; i++) {
    //         totalMoveIntinsity += engines[i].MoveUp (this);
    //     }

    //     //print ("CurrentAddSpeed:" + totalMoveIntinsity * direction);

    //     Vector2 currentAddSpeed = totalMoveIntinsity * direction * Time.deltaTime;

    //     rigid.velocity += currentAddSpeed;

    // }

}