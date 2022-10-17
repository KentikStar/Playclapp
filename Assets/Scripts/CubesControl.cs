using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesControl : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabCube;

    [SerializeField]
    private float rangeSpawn;

    [SerializeField]
    private UIControl uIControl;

    private bool isTimeOver;
    
    void Update()
    {
        if(!isTimeOver){
            ActivationCube();
        }
    }

    private void ActivationCube(){
        GameObject cube;
        SearchFreeCube(out cube);

        cube.transform.position = RandomPosition();
        cube.SetActive(true);
        cube.GetComponent<Cube>().SetValue(uIControl.Speed,uIControl.Distance);

        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer(){
        isTimeOver = true;
        yield return new WaitForSeconds(uIControl.Time);

        isTimeOver = false;
    }

    

    private Vector3 RandomPosition(){
        float xPos = Random.Range(-rangeSpawn,rangeSpawn);

        return new Vector3(xPos, 0.5f, 0);
    }

    private bool SearchFreeCube(out GameObject freeCube){
        foreach(Transform child in transform)
        {
            if(!child.gameObject.activeSelf){
                freeCube = child.gameObject;
                return true;
            }             
        }

        freeCube = SpawnCube();
        return false;
    }

    private GameObject SpawnCube(){
        return Instantiate(prefabCube,transform);
    }

    
}


