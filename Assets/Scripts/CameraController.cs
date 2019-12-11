using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour {
    PlayerController pc;
    CinemachineVirtualCamera myCam;
    Vector3 offset;

    public CameraSettings mouseSettings = new CameraSettings (10f, 0.5f, new Vector2 (2, 20));

    void Start () {
        pc = ResourceManager.Instance.playerController;
        offset = transform.position - pc.transform.position;
        myCam = GetComponent<CinemachineVirtualCamera> ();
    }

    void FixedUpdate () {
        ScaleCamera ();
        LookPlayer ();
    }

    void LookPlayer () {

    }

    void ScaleCamera () {
        float scrollSinsity = Input.GetAxis ("Mouse ScrollWheel");
        if (scrollSinsity != 0) {
            myCam.m_Lens.OrthographicSize -= scrollSinsity * mouseSettings.ScaleSpeed;
        }
        if (myCam.m_Lens.OrthographicSize < mouseSettings.ClampDistance.x)
            myCam.m_Lens.OrthographicSize = mouseSettings.ClampDistance.x;
        else if (myCam.m_Lens.OrthographicSize > mouseSettings.ClampDistance.y)
            myCam.m_Lens.OrthographicSize = mouseSettings.ClampDistance.y;
    }

}

[Serializable]
public struct CameraSettings {
    public float ScaleSpeed;
    public float MoveSpeed;
    public Vector2 ClampDistance;

    public CameraSettings (float scaleSpeed, float mouseSpeed, Vector2 clampDistance) {
        ScaleSpeed = scaleSpeed;
        MoveSpeed = mouseSpeed;
        ClampDistance = clampDistance;
    }
}