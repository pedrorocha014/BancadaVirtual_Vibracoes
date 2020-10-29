using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Imbalance : MonoBehaviour
{   //desbalanceamento ; correção
    private List<string> currentImbalance = new List<string>{
        "Cylinder01;Cylinder1801;270;5",
        "Cylinder901;Cylinder2701;180;10",
        "Cylinder2701;Cylinder901;0;5",
        "Cylinder02;Cylinder1802;270;10",
        "Cylinder1802;Cylinder02;90;5"
    };

    private void Start() {
        string[] currentData = GetImbalanceConfig().Split(';');

        GeneralData.imbalanceObject = currentData[0];
        GeneralData.balanceObject = currentData[1];
        GeneralData.imbalanceAngle = int.Parse(currentData[2]);
        GeneralData.imbalanceMass = int.Parse(currentData[3]);
    }

    private string GetImbalanceConfig(){
        return currentImbalance[Random.Range(0, currentImbalance.Count - 1)];
    }
}
