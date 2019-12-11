using UnityEngine;

public class Part : MonoBehaviour
{
    public float hp;
    public string stringName;
    public string myName;

    public void TakeDamage(float damage){
        hp -= damage;
    }

    public virtual void Death(){
    }
}
