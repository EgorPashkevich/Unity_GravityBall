using UnityEngine;
using System.Collections;

public class speedWorld : MonoBehaviour{

    public float speed = 10f;
    void Start()
    {
        StartCoroutine(speedhigh());
    }

    IEnumerator speedhigh(){
        while(true){
            speed += 0.5f;
            yield return new WaitForSeconds(10f);
        }
    }
}
