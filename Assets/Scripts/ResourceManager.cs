using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;
    public Camera mainCam;
    public PlayerController playerController;
    void Awake(){
        Instance = this;
        mainCam = Camera.main;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
}
