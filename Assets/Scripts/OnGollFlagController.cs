using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnGollFlagController : MonoBehaviour
{
    [SerializeField]
    GameObject textObj;

    [SerializeField]
    GameObject goTitlebutton;

    [SerializeField]
    GameObject reTryButton;

    public PlayerController player;

    void OnTriggerEnter(Collider other)
    {
        player.onGoal = true;
        textObj.SetActive(true);

        Text gollText = textObj.GetComponent<Text>();

        gollText.text = "ゴール!!";

        goTitlebutton.SetActive(true);
        reTryButton.SetActive(true);
        //BoxCollider gollCollider = gollFlag.GetComponent<BoxCollider>();
        //Destroy(gollCollider);
    }

}
