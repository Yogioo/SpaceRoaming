using UnityEngine;

public class Bullet : MonoBehaviour {
    
    public float damage;
    public float speed;

    public float lifeTime;

    void Start(){
        TimeOver();
    }

    public virtual void TimeOver(){
        Destroy(this.gameObject,lifeTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        other.gameObject.GetComponent<Part>().TakeDamage(damage);
    }

    public virtual void Move(){

    }

    void FixedUpdate(){
        Move();
    }


    
}