using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class PlaceManager : MonoBehaviour
{
    private PlaceIndicator placeIndicator;
    public GameObject objectToPlace;
    public Button placeBtn;
    public GameObject placement;
    private ARPlacementInteractable interactable;

    private GameObject newPlacedObject;
    private void Start()
    {
        placeIndicator = FindAnyObjectByType<PlaceIndicator>();
        placement = GameObject.Find("AR Placement Interactable");
        interactable = placement.GetComponent<ARPlacementInteractable>();
    }

    public void ClickToPlace()
    {
        newPlacedObject = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
        placeBtn.gameObject.SetActive(false);
    }

    public void DestoyHoop()
    {
        Destroy(newPlacedObject);
        if (placeBtn != null)
        {
            placeBtn.gameObject.SetActive(true);
        }
    }

  
}
