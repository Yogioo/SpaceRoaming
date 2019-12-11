using UnityEngine;

public class Torpedo : Bullet {

    public override void Move(){
        //transform.Translate(transform.up * Time.deltaTime * speed);
        transform.position += transform.up * speed * Time.deltaTime;
    }

}