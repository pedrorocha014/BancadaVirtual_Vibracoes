using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass : MonoBehaviour
{
    public int index;
    public float massValue;
    [SerializeField]private bool isEnable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
       /* GeneralData.blinkState = false;

       switch (index)
       {
           case 0:
                if(!GeneralData.massState01) {GeneralData.massState01 = true; GeneralData.massValue = GeneralData.massValue + massValue; }
           break;
           case 1:
                if(!GeneralData.massState02) {GeneralData.massState02 = true; GeneralData.massValue = GeneralData.massValue + massValue; }
           break;
           case 2:
                if(!GeneralData.massState03) {GeneralData.massState03 = true; GeneralData.massValue = GeneralData.massValue + massValue; }
           break;
           case 3:
                if(!GeneralData.massState04) {GeneralData.massState04 = true; GeneralData.massValue = GeneralData.massValue + massValue; }
           break;

           default:
           break;
       } */
    }

}
