using UnityEngine;

public class SplitViewScript : MonoBehaviour
{
    public GameObject[] engineParts;
   

   public void OnHullButtonClick(bool val)
    {
       foreach (GameObject part in engineParts) { 
        
            part.SetActive(!val);

        }
        engineParts[0].SetActive(val);
        
    }
    public void OnRottorButtonClick(bool val)
    {
        foreach (GameObject part in engineParts)
        {

            part.SetActive(!val);

        }
        engineParts[1].SetActive(val);
    }

    public void onTailButtonClicked(bool val)
    {
        foreach (GameObject part in engineParts)
        {

            part.SetActive(!val);

        }
        engineParts[2].SetActive(val);
    }
    public void OnSplitViewButtonClicked(bool val)
    {
        foreach (GameObject part in engineParts)
        {

            part.SetActive(val);

        }
    }
   
}
