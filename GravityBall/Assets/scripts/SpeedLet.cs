using UnityEngine;

public class SpeedLet : MonoBehaviour {

    public speedWorld speedlet;

   
    void Update() {
        transform.Translate(Vector3.right * speedlet.speed *  Time.deltaTime);

        if(transform.position.x > 10)
            Destroy(gameObject);            
    }
}