using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class FizzBuzz : MonoBehaviour {
    [SerializeField]
    InputField Inputfizz;
    [SerializeField]
    InputField Inputbuzz;

    int fizz = 0;
    int buzz = 0;


    public void OnClickButton()
    {
        fizz = int.Parse(Inputfizz.text);
        buzz = int.Parse(Inputbuzz.text);


        for(int i = 1;i <= 30; i++)
        {
            //iを文字列に変化
            //i.ToString();
     
            {
                if (i % fizz == 0 && i % buzz == 0)
                {
                    Debug.Log("FizzBuzz");
                }
                else if (i % buzz == 0)
                {
                    Debug.Log("Buzz");
                }
                else if (i % fizz == 0)
                {
                    Debug.Log("Fizz");
                }
                else
                {
                    Debug.Log(i);
                }

            }
        }
    }


}
