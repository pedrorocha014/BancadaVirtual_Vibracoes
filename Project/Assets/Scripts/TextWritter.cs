using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWritter : MonoBehaviour
{
    private Text myText;
    public string type;

    // Start is called before the first frame update
    void Start()
    {
        myText = gameObject.GetComponent<Text>();
        /* GeneralData.rpmValue = 0;
        GeneralData.massValue = 0; */
    }

    // Update is called once per frame
    void Update()
    {
        string rpmText = "";

        switch (type)
        {
            case "rpm":
                if (GeneralData.rpmValue != 0)
                {
                    rpmText = GeneralData.rpmValue < 100 ? "800" : "1000";
                    GeneralData.currentRpm = rpmText;
                }
                GeneralData.rpmTextValue = rpmText;
                myText.text = rpmText + " rpm";
                break;

            case "massa":
                myText.text = GeneralData.massValue.ToString() + " kg";
                break;

            default:
                break;
        }

        
    }
}
