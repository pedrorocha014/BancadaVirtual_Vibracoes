using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParametrosControl : MonoBehaviour
{
    public GameObject[] initialCharts;
    public GameObject[] finalCharts;
    // Start is called before the first frame update
    public void SetCurrentChart(){
        GeneralData.isCorrect = false;
        Debug.Log(GeneralData.imbalanceObject);
        switch (GeneralData.currentRpm) 
        {//5 -> 1  ;; 10 -> 2
            case "800":
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder01"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { GeneralData.isCorrect = true; finalCharts[0].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[1].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[2].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[3].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder2701"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { GeneralData.isCorrect = true;finalCharts[0].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[1].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[2].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[3].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder1802"){
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { finalCharts[16].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[17].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { GeneralData.isCorrect = true;finalCharts[18].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[19].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder901"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { finalCharts[8].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { GeneralData.isCorrect = true; finalCharts[9].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[10].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[11].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder02"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { finalCharts[24].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[25].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[26].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { GeneralData.isCorrect = true;finalCharts[27].SetActive(true); break; }
                }
            break;

            case "1000":
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder01"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { GeneralData.isCorrect = true;finalCharts[4].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[5].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[6].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[7].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder2701"){
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { GeneralData.isCorrect = true;finalCharts[4].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[5].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[6].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[7].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder1802"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { finalCharts[20].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[21].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { GeneralData.isCorrect = true;finalCharts[22].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[23].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder901"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { finalCharts[12].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) {GeneralData.isCorrect = true; finalCharts[13].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[14].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) { finalCharts[15].SetActive(true); break; }
                }
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder02"){ 
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 5) { finalCharts[28].SetActive(true); break; }
                    if(GeneralData.currentRadius == "1" && GeneralData.currentMass == 10) { finalCharts[29].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 5) { finalCharts[30].SetActive(true); break; }
                    if(GeneralData.currentRadius == "2" && GeneralData.currentMass == 10) {GeneralData.isCorrect = true; finalCharts[31].SetActive(true); break; }
                }
            break;
        }
    }

    public void SetInitialChart(){
        //acoplado no TextWritter
        switch (GeneralData.currentRpm) 
        {
            case "800":
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder01"){ initialCharts[0].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder2701"){ initialCharts[0].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder1802"){ initialCharts[4].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder901"){ initialCharts[2].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder02"){ initialCharts[6].SetActive(true); break;}
            break;

            case "1000":
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder01"){ initialCharts[1].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder2701"){ initialCharts[4].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 5 && GeneralData.imbalanceObject == "Cylinder1802"){ initialCharts[5].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder901"){ initialCharts[3].SetActive(true); break;}
                if(GeneralData.imbalanceMass == 10 && GeneralData.imbalanceObject == "Cylinder02"){ initialCharts[7].SetActive(true); break;}
            break;
        }
    }

    public void Unable(){
        foreach (GameObject item in initialCharts)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in finalCharts)
        {
            item.SetActive(false);
        }
    }
}
