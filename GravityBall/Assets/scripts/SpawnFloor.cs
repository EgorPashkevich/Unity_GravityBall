using UnityEngine;


public class SpawnFloor : MonoBehaviour{
    public GameObject floor;
    public speedWorld speedfloor;

    // public Rigidbody rb;


    void Update(){
        transform.Translate(Vector3.right * speedfloor.speed * Time.deltaTime);

        if(transform.position.x > 10f){
            var newfloor = Instantiate(floor, transform.position + new Vector3(-60f, 0f, 0f), Quaternion.identity);
            newfloor.GetComponent<SpawnFloor>().InitSpeedfloor(speedfloor);
            Destroy(gameObject);
        }
    }

    // private void FixedUpdate() {
    //     rb.MovePosition(rb.position + Vector3.right * speedfloor.speed * Time.fixedDeltaTime);
    //     Debug.LogError(Vector3.right + rb.transform.position);
    // }

    public void InitSpeedfloor(speedWorld sf){
        speedfloor = sf;
    }
    
}
