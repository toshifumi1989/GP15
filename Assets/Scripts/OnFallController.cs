using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnFallController : MonoBehaviour
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
        player.onFall = true;
        textObj.SetActive(true);
        goTitlebutton.SetActive(true);

        Text fallText = textObj.GetComponent<Text>();

        fallText.text = "ゲームオーバー";

        goTitlebutton.SetActive(true);
        reTryButton.SetActive(true);
    }

}
