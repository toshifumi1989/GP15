using UnityEngine;
//using UnityEngine.SceneManagement;　　５．３以降
using System.Collections;

public class TittleSceneController : MonoBehaviour
{   


    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        //5.3以降
    //        //SceneManager.LoadLevel("シーン名");

    //        //5.2以前
    //        Application.LoadLevel("BallRoll");
    //    }

    //}


    public void TittleMove()
    {

        Application.LoadLevel("BallRoll");

    }

}
