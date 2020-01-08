using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Vector3 size;
    public Vector3 centre;

    public GameObject[] InstCube;
    public Transform spawnpos;

    int randomInt;
    private void Awake() {
      
    }
    private void Update() {
        if (Input.GetKey(KeyCode.D)) {
            spawnFood();
        }
    }
    private void OnDrawGizmosSelected() {
        Gizmos.color = new Color(1,0,0,0.5f);
        Gizmos.DrawCube(centre,size);
    }
    public void spawnFood() {
        //Vector3 pos = centre+new Vector3(Random.Range(size.x/2, size.x / 2),Random.Range(size.y / 2, size.y / 2),Random.Range(size.y / 2, size.y / 2));
        //Instantiate(InstCube, transform.position, Quaternion.identity);

        randomInt = Random.Range(0,InstCube.Length);
        Instantiate(InstCube[randomInt],spawnpos.position,spawnpos.rotation);
        Destroy(InstCube[randomInt],0.5f);
    }
}
