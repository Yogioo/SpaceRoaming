using UnityEngine;

public class LayzerSpawner : Weapon {
    public Vector3 dir;
    public float distance = 5;
    public float damage = 1;
    private GameObject layzer;

    ResourceManager resourceManager;

    void Start () {
        resourceManager = ResourceManager.Instance;
        GameObject layzerPre = resourceManager.layzerPrefab;
        // 激光武器中只能有一个激光
        layzer = GameObject.Instantiate (layzerPre, initPos[0]);
        layzer.SetActive (false);

    }

    // 激活武器 使得武器可以被控制(通过按键激活控制 鼠标左键发射武器)
    public override void ActiveWeapon () {
        Vector3 mousePos = resourceManager.GetMousePos ();

        dir = mousePos - transform.position;
        dir.z = 0;

        transform.up = dir;

        if (Input.GetMouseButton (0)) {
            layzer.SetActive (true);
            Shoot (mousePos);
        } else {
            layzer.SetActive (false);
        }

    }

    // 射线发射+伤害检测
    void Shoot (Vector3 pos) {
        RaycastHit2D hit = Physics2D.Raycast (transform.position, dir, distance, ~(1 << 8));
        if (hit.collider == null) {
            layzer.GetComponent<LineRenderer> ().SetPosition (1, new Vector3 (0, distance, 0));
        } else {
            float distance = Vector3.Magnitude (new Vector3 (hit.point.x, hit.point.y, 0) - transform.position);

            layzer.GetComponent<LineRenderer> ().SetPosition (1, new Vector3 (0, distance, 0));

            Attack (hit.collider.GetComponent<Part> ());
        }

    }

    void Attack (Part target) {
        target.TakeDamage (damage * Time.deltaTime);
    }

}