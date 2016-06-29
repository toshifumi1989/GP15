using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Square : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        {
            string word = "";

            for (int j = 0; j < 5; j++)
            {
                string square = "";
                for (int i = 0; i < 5; i++)
                {

                    square += "□";
                    if (i == 4)
                    {
                        square += "\n";
                        word += square;
                    }
                }

            }
            Debug.Log(word);
        }

        {
            string word = "";

            for (int j = 0; j < 5; j++)
            {
                string square = "";
                for (int i = 0; i <= j; i++)
                {
                    square += "□";
                    if (i == j)
                    {
                        square += "\n";
                        word += square;
                    }
                }
            }
            Debug.Log(word);
        }

        {
            string word = "";

            for (int j = 0; j < 5; j++)
            {
                string square = "";
                for (int i = 0; i < 5; i++)
                {
                    if (i <= j)
                    {
                        square += "□";
                    }
                    else
                    {
                        square += "■";
                    }

                    if (i == 4)
                    {
                        square += "\n";
                        word += square;
                    }
                }
            }
            Debug.Log(word);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
