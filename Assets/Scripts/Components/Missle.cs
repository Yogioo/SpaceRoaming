using UnityEngine;

public class Missle : Bullet {

    public Transform target;
    public float rotateSpeed = 1;
    
    public override void Move(){
        // 向前移动
        transform.position += transform.up * speed * Time.deltaTime;
        
        if(target == null)
            return;
        // 转向
        Vector2 offset = (target.position - transform.position).normalized;
        float angle = Vector2.Angle(transform.up, offset);
        transform.up = Vector2.Lerp(transform.up, offset, rotateSpeed*Time.deltaTime).normalized;
        
        
    }


    
}