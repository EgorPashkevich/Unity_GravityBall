using System.Collections;
using UnityEngine;

public class SpawnLets : MonoBehaviour{    

    public GameObject led;
    public speedWorld speedglobal;

    private float[] positions = {-1f, 0f, 1f};
    private float[] positions_y = {0.75f, 1.75f, 2.75f};

    private void Start() {
        StartCoroutine(spawn());
    }

    IEnumerator spawn(){
        while(true){
                var letnew = Instantiate(
                    led, 
                    new Vector3(-80f, 1.75f, positions[Random.Range(0, 3)]), 
                    Quaternion.Euler(new Vector3(0, 0, 0)));
                var letnew2 = Instantiate(
                    led, 
                    new Vector3(-80f, 1.75f, positions[Random.Range(0, 3)]), 
                    Quaternion.Euler(new Vector3(0, 0, 0)));
                var letnew3 = Instantiate(
                    led, 
                    new Vector3(-80.1f, positions_y[Random.Range(0, 3)], 0f), 
                    Quaternion.Euler(new Vector3(90, 0, 0)));
                var letnew4 = Instantiate(
                    led, 
                    new Vector3(-80.1f, positions_y[Random.Range(0, 3)], 0f), 
                    Quaternion.Euler(new Vector3(90, 0, 0)));
                letnew.GetComponent<SpeedLet>().speedlet = speedglobal;
                letnew2.GetComponent<SpeedLet>().speedlet = speedglobal;
                letnew3.GetComponent<SpeedLet>().speedlet = speedglobal;
                letnew4.GetComponent<SpeedLet>().speedlet = speedglobal;

            yield return new WaitForSeconds(5f);
        }
    }
}
