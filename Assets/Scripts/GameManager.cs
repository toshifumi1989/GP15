using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    GameObject goTitlebutton;

    [SerializeField]
    GameObject reTryButton;

    public PlayerController player;

    void GoTitle()
    {
        Application.LoadLevel("Tittle");
    }

    void Retry()
    {   
        player.onGoal = false;
        player.onFall = false;
    }

}
