using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineControl : MonoBehaviour
{
    public Slider slider;
    private float rpmValue;
    
    public float RPM_Value
    {
        get
        {
            //Some other code
            return (rpmValue * 10)/6000;
        }
        set
        {
            //Some other code
            if (value != rpmValue) { finalRotation = value; initialRotation = rpmValue; UpdateRotation(); }
        }
    }
    //Coroutine variables

    private float interpolateFactor;
    private float interpolateFactor_switch;
    private float initialRotation, currentRotation, finalRotation; 

    void Start(){
        rpmValue = 0;
        GeneralData.interruptor = false;
    }

    public void CallUpdateAngle(){
        GeneralData.interruptor = ! GeneralData.interruptor; 

        StartCoroutine(UpdateAngle());
    }

    private void UpdateRotation(){
        interpolateFactor = 0;
        StartCoroutine("SmoothRotation");
    }

    private IEnumerator SmoothRotation(){
        while(interpolateFactor < 1){
            currentRotation = Mathf.Lerp(initialRotation, finalRotation, interpolateFactor);
            rpmValue = currentRotation;
            yield return new WaitForSeconds(0.01f);
            interpolateFactor += 0.01f;
            GeneralData.rpmValue = rpmValue;
        }
    }

    private IEnumerator UpdateAngle(){
        while(GeneralData.interruptor){

            transform.eulerAngles = new Vector3(transform.eulerAngles.x  + rpmValue , transform.eulerAngles.y , transform.eulerAngles.z );

            yield return new WaitForSeconds(0.1f);
        }
        StartCoroutine(ReduceSpeed(rpmValue));
    }

    private IEnumerator ReduceSpeed(float currentRPM){
        interpolateFactor = 0;
        
        while(interpolateFactor < 1){
            currentRotation = Mathf.Lerp(currentRPM, 0, interpolateFactor);
            rpmValue = currentRotation;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x  + rpmValue , transform.eulerAngles.y , transform.eulerAngles.z );
            yield return new WaitForSeconds(0.01f);
            interpolateFactor += 0.01f;
            GeneralData.rpmValue = rpmValue;
        }

        slider.value = 0;
    }
}