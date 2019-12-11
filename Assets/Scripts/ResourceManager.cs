using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;
    public Camera mainCam;
    public PlayerController playerController;
    
    public Sprite[] bulletSprites;
    public GameObject misslePrefab;
    public GameObject torpedoPrefab;
    public GameObject layzerPrefab;
    
    private Vector2 mousePos;

    void Awake(){
        Instance = this;
        mainCam = Camera.main;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        bulletSprites = Resources.LoadAll<Sprite>("Bullet/Bullet_Sprite");
        misslePrefab = Resources.Load<GameObject>("Bullet/MisslePrefab");
        torpedoPrefab = Resources.Load<GameObject>("Bullet/TorpedoPrefab");
        layzerPrefab = Resources.Load<GameObject> ("Bullet/LayzerPrefab");
    }

    void GetMisslePrefab(){

    }

    void GetTorpedoPrefab(){

    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        UpdateMousePos();
    }

    void UpdateMousePos(){
        Ray ray = mainCam.ScreenPointToRay (Input.mousePosition);
        if (Physics.Raycast (ray, out RaycastHit hit, 200)) {
            mousePos = hit.point - transform.position;
        }
    }

    public Vector2 GetMousePos(){
        return mousePos;
    }
    


}
