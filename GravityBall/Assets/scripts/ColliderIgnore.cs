using System.Collections;
using UnityEngine;

public class ColliderIgnore : MonoBehaviour
{
    private DestroyLet DL;
    private MeshRenderer  _mesh;

    public float _time = 10f;

    private void Start() {
        DL = GetComponent<DestroyLet>();
        _mesh = GetComponent<MeshRenderer>();
    }
    public GameObject _pl;
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<boost>()){
            DL._bool = true;
            _mesh.material.color = Color.gray;
            StartCoroutine(boolsec());
            Destroy(other.gameObject);
        }
    }
    private IEnumerator boolsec(){
        yield return new WaitForSeconds(_time);
        _mesh.material.color = Color.yellow;
        DL._bool = false;
    }
}
