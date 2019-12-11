using UnityEngine;

public class Torpedo : Bullet {

    public override void Move(){
        transform.position += transform.up * speed * Time.deltaTime;
    }

}