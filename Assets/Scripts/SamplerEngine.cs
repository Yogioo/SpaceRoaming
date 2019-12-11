using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SamplerEngine : MonoBehaviour {
    public TrailRenderer myTrail;
    public ParticleSystem particle;

    public Rigidbody2D target;
    public KeyCode myKey;
    public float enginePower = 50;

    void Awake () {
        myTrail = transform.Find ("Trail").GetComponent<TrailRenderer> ();
        particle = transform.Find ("Particle System").GetComponent<ParticleSystem> ();
        particle.Stop ();
    }
    public void EnginOn (Rigidbody2D rigid) {
        Vector2 force = transform.up * enginePower;
        rigid.AddForceAtPosition (force, transform.position);
    }

    void Update () {
        if (Input.GetKey (myKey)) {
            StartPartical();
            EnginOn (target);
        }else{
            StopPartical();
        }
    }

    void StopPartical () {
        if (particle.isPlaying)
            particle.Stop ();

        StartCoroutine(MinusTrailLength());
    }

    void StartPartical () {
        if (particle.isPlaying == false)
            particle.Play ();
        myTrail.time = target.velocity.magnitude / 10;
        
    }

    IEnumerator MinusTrailLength(){
        while(myTrail.time > 0){
            yield return new WaitForEndOfFrame();
            myTrail.time -= Time.deltaTime;
        }
    }

}