using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassField : MonoBehaviour
{
    public string fieldName;
    public string radius;
    public string position;
    public bool status;
    // Start is called before the first frame update
    void Start()
    {
        status = false;
    }

    void OnMouseDown()
    {
        status =! status;
        GeneralData.blinkState = false;
        if (status){
            GeneralData.currentRadius = radius;
            GeneralData.currentPosition = position;
            
            switch (fieldName)
            {
                case "01":
                    GeneralData.massState01 = status;
                break;
                case "451":
                    GeneralData.massState02 = status;
                break;
                case "901":
                    GeneralData.massState03 = status;
                break;
                case "1351":
                    GeneralData.massState04 = status;
                break;
                case "1801":
                    GeneralData.massState05 = status;
                break;
                case "2251":
                    GeneralData.massState06 = status;
                break;
                case "2701":
                    GeneralData.massState07 = status;
                break;
                case "3151":
                    GeneralData.massState08 = status;
                break;
                case "02":
                    GeneralData.massState09 = status;
                break;
                case "452":
                    GeneralData.massState10 = status;
                break;
                case "902":
                    GeneralData.massState11 = status;
                break;
                case "1352":
                    GeneralData.massState12 = status;
                break;
                case "1802":
                    GeneralData.massState13 = status;
                break;
                case "2252":
                    GeneralData.massState14 = status;
                break;
                case "2702":
                    GeneralData.massState15 = status;
                break;
                case "3152":
                    GeneralData.massState16 = status;
                break;
                
                default:
                break;
            }
        }
    }
}
