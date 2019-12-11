using UnityEngine;

public class Part : MonoBehaviour
{
    public float hp;
    public void TakeDamage(float damage){
        hp -= damage;
    }
    

    public virtual void  ActiveSpecial(){
    }

    public virtual void Death(){
    }
}
