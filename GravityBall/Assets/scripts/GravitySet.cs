using UnityEngine;

public class GravitySet : MonoBehaviour{

    void GravityRight(){
        Physics.gravity = new Vector3(0f, 0f, 9.81f);
    }
    void GravityLeft(){
        Physics.gravity = new Vector3(0f, 0f, -9.81f);
    }
    void GravityUp(){
        Physics.gravity = new Vector3(0f, 9.81f, 0f);
    }
    void GravityDown(){
        Physics.gravity = new Vector3(0f, -9.81f, 0f);
    }

   private void FixedUpdate() {
        if(Input.GetKey(KeyCode.D)){
            GravityRight();
        }   
        if(Input.GetKey(KeyCode.A)){
            GravityLeft();
        }   
        if(Input.GetKey(KeyCode.W)){
            GravityUp();
        }   
        if(Input.GetKey(KeyCode.S)){
            GravityDown();
        }   
   }
}
