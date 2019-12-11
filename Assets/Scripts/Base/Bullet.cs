using UnityEngine;

public class Bullet : Part {
    
    public float damage = 1;
    public float speed = 1;

    public float lifeTime = 5;

    void Start(){
        TimeOver();
    }

    public virtual void TimeOver(){
        Destroy(this.gameObject,lifeTime);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        other.gameObject.GetComponent<Part>().TakeDamage(damage);
    }

    public virtual void Move(){}

    void FixedUpdate(){
        Move();
    }
    
}