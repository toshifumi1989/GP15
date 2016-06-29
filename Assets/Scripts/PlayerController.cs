using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    Rigidbody rigid;

    public bool onGoal = false;
    public bool onFall = false;

    public bool goRetry = false;

    // [SerializeField]
    // GameObject retryButton;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (onGoal || onFall)
        {
            rigid.velocity *= 0.9f;

            

            return;
        }


        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigid.AddForce(movement * 10);


        if (goRetry == true)
        {
            rigid.position = new Vector3(0, 0, 0);
        }


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rigid.AddForce(new Vector3(0f, 500f, 0f));
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //{
        //    rigid.AddForce(new Vector3(0f, 0f, 100f));
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    rigid.AddForce(new Vector3(-100f, 0f, 0f));
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    rigid.AddForce(new Vector3(100f, 0f, 0f));
        //}
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    rigid.AddForce(new Vector3(0f, 0f, -100f));
        //}
    }

}
