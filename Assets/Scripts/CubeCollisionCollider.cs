using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CubeCollisionCollider : MonoBehaviour
{
    //他のクラスからのアクセスはできないが、エディタからはアクセス可能
    [SerializeField]
    GameObject textObj;

    //他のクラス、エディタからもアクセス可能
    //public GameObject textObj;

    //物理的接触判定が有
    void OnCollisionEnter(Collision other)
    {
        // Destroy(other.gameObject);//破壊
        textObj.SetActive(true);//表示をONにする

    }

    //物理的なしの通過可能の接触判定
    void OnTriggerEnter (Collider other)
    {
        textObj.SetActive(true);

        Text t = textObj.GetComponent<Text>();
        t.text = "キューブが通過したよー";

    }
}
