using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassController : MonoBehaviour
{
    public GameObject mass01Blink;
    public GameObject mass02Blink;
    public GameObject mass03Blink;
    public GameObject mass04Blink;
    public GameObject mass05Blink;
    public GameObject mass06Blink;
    public GameObject mass07Blink;
    public GameObject mass08Blink;
    public GameObject mass09Blink;
    public GameObject mass10Blink;
    public GameObject mass11Blink;
    public GameObject mass12Blink;
    public GameObject mass13Blink;
    public GameObject mass14Blink;
    public GameObject mass15Blink;
    public GameObject mass16Blink;

    public GameObject mass01;
    public GameObject mass02;
    public GameObject mass03;
    public GameObject mass04;
    public GameObject mass05;
    public GameObject mass06;
    public GameObject mass07;
    public GameObject mass08;
    public GameObject mass09;
    public GameObject mass10;
    public GameObject mass11;
    public GameObject mass12;
    public GameObject mass13;
    public GameObject mass14;
    public GameObject mass15;
    public GameObject mass16;
    private bool objState;
    public CameraControl cameraControl;
    public Experimento01 experimento;

    // Start is called before the first frame update
    void Start()
    {
        CheckMassStates();
        objState = false;
    }

    void OnMouseDown()
    {
        if (!GeneralData.blinkState) { EnableObject(); GeneralData.blinkState = true; StartCoroutine("BlinkMass"); }
    }

    public IEnumerator BlinkMass()
    {
        UnSetMass();
        UnableMassas();
        GeneralData.blinkState = true;
        Debug.Log(GeneralData.blinkState);
        while (GeneralData.blinkState)
        {
            mass01Blink.GetComponent<MeshRenderer>().enabled = false;
            mass02Blink.GetComponent<MeshRenderer>().enabled = false;
            mass03Blink.GetComponent<MeshRenderer>().enabled = false;
            mass04Blink.GetComponent<MeshRenderer>().enabled = false;
            mass05Blink.GetComponent<MeshRenderer>().enabled = false;
            mass06Blink.GetComponent<MeshRenderer>().enabled = false;
            mass07Blink.GetComponent<MeshRenderer>().enabled = false;
            mass08Blink.GetComponent<MeshRenderer>().enabled = false;
            mass09Blink.GetComponent<MeshRenderer>().enabled = false;
            mass10Blink.GetComponent<MeshRenderer>().enabled = false;
            mass11Blink.GetComponent<MeshRenderer>().enabled = false;
            mass12Blink.GetComponent<MeshRenderer>().enabled = false;
            mass13Blink.GetComponent<MeshRenderer>().enabled = false;
            mass14Blink.GetComponent<MeshRenderer>().enabled = false;
            mass15Blink.GetComponent<MeshRenderer>().enabled = false;
            mass16Blink.GetComponent<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);

            mass01Blink.GetComponent<MeshRenderer>().enabled = true;
            mass02Blink.GetComponent<MeshRenderer>().enabled = true;
            mass03Blink.GetComponent<MeshRenderer>().enabled = true;
            mass04Blink.GetComponent<MeshRenderer>().enabled = true;
            mass05Blink.GetComponent<MeshRenderer>().enabled = true;
            mass06Blink.GetComponent<MeshRenderer>().enabled = true;
            mass07Blink.GetComponent<MeshRenderer>().enabled = true;
            mass08Blink.GetComponent<MeshRenderer>().enabled = true;
            mass09Blink.GetComponent<MeshRenderer>().enabled = true;
            mass10Blink.GetComponent<MeshRenderer>().enabled = true;
            mass11Blink.GetComponent<MeshRenderer>().enabled = true;
            mass12Blink.GetComponent<MeshRenderer>().enabled = true;
            mass13Blink.GetComponent<MeshRenderer>().enabled = true;
            mass14Blink.GetComponent<MeshRenderer>().enabled = true;
            mass15Blink.GetComponent<MeshRenderer>().enabled = true;
            mass16Blink.GetComponent<MeshRenderer>().enabled = true;
            yield return new WaitForSeconds(0.5f);

            Debug.Log(GeneralData.blinkState);
        }

        EnableObject();
        CheckMassStates();
    }

    private void UnableMassas()
    {
        GeneralData.massState01 = false;
        GeneralData.massState02 = false;
        GeneralData.massState03 = false;
        GeneralData.massState04 = false;
        GeneralData.massState05 = false;
        GeneralData.massState06 = false;
        GeneralData.massState07 = false;
        GeneralData.massState08 = false;
        GeneralData.massState09 = false;
        GeneralData.massState10 = false;
        GeneralData.massState11 = false;
        GeneralData.massState12 = false;
        GeneralData.massState13 = false;
        GeneralData.massState14 = false;
        GeneralData.massState15 = false;
        GeneralData.massState16 = false;
    }

    private void EnableObject()
    {
        mass01Blink.GetComponent<MeshRenderer>().enabled = false;
        mass02Blink.GetComponent<MeshRenderer>().enabled = false;
        mass03Blink.GetComponent<MeshRenderer>().enabled = false;
        mass04Blink.GetComponent<MeshRenderer>().enabled = false;
        mass05Blink.GetComponent<MeshRenderer>().enabled = false;
        mass06Blink.GetComponent<MeshRenderer>().enabled = false;
        mass07Blink.GetComponent<MeshRenderer>().enabled = false;
        mass08Blink.GetComponent<MeshRenderer>().enabled = false;
        mass09Blink.GetComponent<MeshRenderer>().enabled = false;
        mass10Blink.GetComponent<MeshRenderer>().enabled = false;
        mass11Blink.GetComponent<MeshRenderer>().enabled = false;
        mass12Blink.GetComponent<MeshRenderer>().enabled = false;
        mass13Blink.GetComponent<MeshRenderer>().enabled = false;
        mass14Blink.GetComponent<MeshRenderer>().enabled = false;
        mass15Blink.GetComponent<MeshRenderer>().enabled = false;
        mass16Blink.GetComponent<MeshRenderer>().enabled = false;
    }

    private void CheckMassStates()
    {
        mass01.SetActive(GeneralData.massState01);
        mass02.SetActive(GeneralData.massState02);
        mass03.SetActive(GeneralData.massState03);
        mass04.SetActive(GeneralData.massState04);
        mass05.SetActive(GeneralData.massState05);
        mass06.SetActive(GeneralData.massState06);
        mass07.SetActive(GeneralData.massState07);
        mass08.SetActive(GeneralData.massState08);
        mass09.SetActive(GeneralData.massState09);
        mass10.SetActive(GeneralData.massState10);
        mass11.SetActive(GeneralData.massState11);
        mass12.SetActive(GeneralData.massState12);
        mass13.SetActive(GeneralData.massState13);
        mass14.SetActive(GeneralData.massState14);
        mass15.SetActive(GeneralData.massState15);
        mass16.SetActive(GeneralData.massState16);

        experimento.GetComponent<Experimento01>().GetContinueValue();
    }

    private void UnSetMass()
    {
        mass01.SetActive(false);
        mass02.SetActive(false);
        mass03.SetActive(false);
        mass04.SetActive(false);
        mass05.SetActive(false);
        mass06.SetActive(false);
        mass07.SetActive(false);
        mass08.SetActive(false);
        mass09.SetActive(false);
        mass10.SetActive(false);
        mass11.SetActive(false);
        mass12.SetActive(false);
        mass13.SetActive(false);
        mass14.SetActive(false);
        mass15.SetActive(false);
        mass16.SetActive(false);
    }
}
