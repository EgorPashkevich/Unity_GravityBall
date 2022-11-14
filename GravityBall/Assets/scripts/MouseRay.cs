using UnityEngine;
using System.Collections;
using System.Runtime;

public class MouseRay : MonoBehaviour{

    public Rigidbody _player;
    // private Vector3 end;
    // private float progress;
    // public float step;
    // private float playerpositionnow;
    private void Awake() {
        _player = GetComponent<Rigidbody>();
    }

    void FixedUpdate(){   
        if (Physics.gravity.y != 0){
            Move_player_y_gravity();
        }
        else {
            Move_player_z_gravity();
        }

    
    }
    void Move_player_y_gravity(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                _player.AddForce(0f, 0f, hit.transform.position.z - _player.transform.position.z, ForceMode.Impulse);
            }
        // }
    }

    void Move_player_z_gravity(){
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                _player.AddForce(0f, hit.transform.position.y - _player.transform.position.y, 0f, ForceMode.Impulse);
                // Debug.Log(hit.transform.position.y);
            }
        // }
    }
}
