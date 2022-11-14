using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLet : MonoBehaviour
{
    public bool _bool;
    private void OnCollisionEnter(Collision other) {
        if(_bool == true){
            if(other.gameObject.name == "let(Clone)" ){
                Destroy(other.gameObject);
            }
        }
    }
}