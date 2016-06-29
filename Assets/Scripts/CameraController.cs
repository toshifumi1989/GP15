using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    [SerializeField]
    GameObject player;


	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 cameraMove = new Vector3(0, 1.5f, -5);

        transform.position = player.transform.position + cameraMove;


    }
}
