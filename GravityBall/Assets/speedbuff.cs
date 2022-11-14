using UnityEngine;

public class speedbuff : MonoBehaviour
{
    public speedWorld speedworld;
    void Update(){
        transform.Translate(Vector3.right * speedworld.speed * Time.deltaTime);
        // Debug.Log(speedworld.speed);
        if(transform.position.x > 10)
            Destroy(gameObject);
    }
}
