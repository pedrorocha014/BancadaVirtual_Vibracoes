using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateWheel : MonoBehaviour
{
    public Text currentAngleLabel;
    private float initialAngle;
    private float startAngle;
    public float StartAngle
    {
        get { return startAngle; }
        set { UpdateAngle(value); }
    }

    private void UpdateAngle(float value)
    {
        Debug.Log(startAngle);
        StopCoroutine(ReturnToAngle());
        startAngle = value;
        transform.Rotate(startAngle - initialAngle,0,0);
        initialAngle = startAngle;
        currentAngleLabel.text = value.ToString("###º");
    }

    public void LeaveWheel(){
        StartCoroutine(ReturnToAngle());
    }

    private IEnumerator ReturnToAngle()
    {
        float interpolateFactor = 0;

        float initialAngle = transform.eulerAngles.x;
        float currentAngle = initialAngle;

        while (interpolateFactor < 1)
        {

            currentAngle = Mathf.Lerp(initialAngle, GeneralData.imbalanceAngle, interpolateFactor);

            yield return new WaitForSeconds(0.1f);

            transform.eulerAngles = new Vector3(currentAngle,
                                            transform.eulerAngles.y,
                                            transform.eulerAngles.z);
            interpolateFactor += 0.05f;
        }
    }

}
