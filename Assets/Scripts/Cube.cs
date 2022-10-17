using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float speed;
    private float distance;

    public void SetValue(float speed, float distance){
        this.speed = speed;
        this.distance = distance;
    }

    void Update()
    {
        MoveForward();
    }

    private void MoveForward(){
        if(distance >= 0){
            Vector3 step = Vector3.forward * speed * Time.deltaTime;
            transform.position += step;
            distance -= step.z;
        } else
            gameObject.SetActive(false);
    }
}
