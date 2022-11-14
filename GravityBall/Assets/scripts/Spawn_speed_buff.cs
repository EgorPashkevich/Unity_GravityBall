using System.Collections;
using UnityEngine;

public class Spawn_speed_buff : MonoBehaviour
{
    public GameObject buff;
    public GameObject let;
    public speedWorld speedw;
    private GameObject[] letsfind;
    void Start()
    {
        StartCoroutine(SpawnBuff());
    }

    IEnumerator SpawnBuff(){
        while(true){
            var buffnew = Instantiate(buff, new Vector3(-80.1f, 1.75f, 0f), Quaternion.Euler(new Vector3(0, 0, 0)));
            buffnew.GetComponent<speedbuff>().speedworld = speedw;
            yield return new WaitForSeconds(5f);
        }
    }
}
